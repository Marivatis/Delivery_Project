using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.DataControl.Enums;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.DataControl.Workplaces.Management;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Courier
{
    public partial class FormCourier : CustomBorderForm
    {
        private FormCourierProfile formProfile;

        private DeliveryCourier courier;

        private DeliveryOrder? selectedOrder;
        private List<DeliveryOrder>? waitingOrdersList;

        public static Func<List<DeliveryOrder>?>? GetWaitingOrdersList;
        public static Func<string, DeliveryOrder?>? GetTakenOrder;
        public static Func<string, bool>? OrderOnTheWay;
        public static TakeOrder? TakeOrder;
        public static FinishOrder? FinishOrder;

        public FormCourier(ref DeliveryCourier courier) : base()
        {
            InitializeComponent();

            this.courier = courier;
        }

        private void FormCourier_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            DataGridView_Load();
            TakenOrder_Load();
        }

        private void DataGridView_Load()
        {
            waitingOrdersList = GetWaitingOrdersList?.Invoke();

            if (waitingOrdersList is null)
                return;

            dataGridView1.Rows.Clear();

            foreach (var order in waitingOrdersList)
            {
                dataGridView1.Rows.Add(order.CourierEarning, order.CustomerAddress, order.ProviderPlaceAddress);
            }

            dataGridView1.ClearSelection();
        }
        private void TakenOrder_Load()
        {
            DeliveryOrder? order = GetTakenOrder?.Invoke(courier.Login);

            if (order is null)
                return;

            ShowOrderDetails(order);

            labelDeliveryStatus.Text = $"Delivery status: {order.OrderStatus}";
            labelDeliveryStatus.Visible = true;

            dataGridView1.Enabled = false;

            if (order.OrderStatus == DeliveryOrderStatus.Accepted)
                buttonTakeOrder.Text = "I`m on the way";
            else if (order.OrderStatus == DeliveryOrderStatus.OnTheWay)
                buttonTakeOrder.Text = "Finish delivery";

            selectedOrder = order;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int earning = Convert.ToInt32(row.Cells["Earning"].Value);
            string customerAddress = row.Cells["DestinationAddress"].Value.ToString() ?? string.Empty;
            string providerPlaceAddress = row.Cells["ProviderAdress"].Value.ToString() ?? string.Empty;

            selectedOrder = FindOrder(earning, customerAddress, providerPlaceAddress);

            if (selectedOrder is null)
                return;

            ShowOrderDetails(selectedOrder);
        }

        private DeliveryOrder? FindOrder(int earning, string customerAddress, string providerPlaceAddress)
        {
            return waitingOrdersList?.FirstOrDefault(o => o.CourierEarning == earning &&
                                                    o.CustomerAddress == customerAddress &&
                                                    o.ProviderPlaceAddress == providerPlaceAddress);
        }

        private void ShowOrderDetails(DeliveryOrder order)
        {
            listBoxOrderDetails.Items.Clear();

            foreach (var key in order.OrderCart.Cart)
            {
                listBoxOrderDetails.Items.Add(order.OrderCart.KeyToString(key));
            }

            labelPlaceName.Text = $"Place name: {order.ProviderPlaceName}";
            labelPlaceName.Visible = true;

            labelCustomerLogin.Text = $"Customer login: {order.CustomerLogin}";
            labelCustomerLogin.Visible = true;
            labelCustomerPhone.Text = $"Customer phone: {order.CustomerPhone}";
            labelCustomerPhone.Visible = true;

            labelTotalEarning.Text = $"Total earning: {order.CourierEarning} UAH";
            labelTotalEarning.Visible = true;
        }
        private void ClearOrderDetails()
        {
            waitingOrdersList?.Clear();
            listBoxOrderDetails.Text = null;

            labelPlaceName.Text = $"Place name:";
            labelPlaceName.Visible = false;

            labelCustomerLogin.Text = $"Customer login:";
            labelCustomerLogin.Visible = false;
            labelCustomerPhone.Text = $"Customer phone:";
            labelCustomerPhone.Visible = false;

            labelTotalEarning.Text = $"Total earning:";
            labelTotalEarning.Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataGridView_Load();

            if (selectedOrder?.OrderStatus == DeliveryOrderStatus.Accepted || selectedOrder?.OrderStatus == DeliveryOrderStatus.OnTheWay)
                return;

            ClearOrderDetails();
        }

        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            switch (buttonTakeOrder.Text)
            {
                case "Take Order":
                    buttonTakeOrder_TakeOrder_Click();
                    break;
                case "I`m on the way":
                    buttonTakeOrder_OnTheWay_Click();
                    break;
                case "Finish delivery":
                    buttonTakeOrder_FinishDelivery_Click();
                    break;
            }
        }
        private void buttonTakeOrder_TakeOrder_Click()
        {
            string message = "Something went wrong";

            bool isTaken = TakeOrder?.Invoke(selectedOrder, courier, ref message) ?? false;

            if (!isTaken)
            {
                MessageBox.Show(message);
                return;
            }

            TakenOrder_Load();

            waitingOrdersList?.Remove(selectedOrder);
            DataGridView_Load();
        }
        private void buttonTakeOrder_OnTheWay_Click()
        {
            bool isOnTheWay = OrderOnTheWay?.Invoke(courier.Login) ?? false;

            if (!isOnTheWay)
            {
                MessageBox.Show("Something went wrong.");
                return;
            }

            selectedOrder.OrderStatus = DeliveryOrderStatus.OnTheWay;

            labelDeliveryStatus.Text = $"Delivery status: {selectedOrder.OrderStatus}";
            labelDeliveryStatus.Visible = true;

            buttonTakeOrder.Text = "Finish delivery";
        }
        private void buttonTakeOrder_FinishDelivery_Click()
        {
            string message = "Something went wrong.";

            bool isFinished = FinishOrder?.Invoke(courier.Login, ref message) ?? false;

            MessageBox.Show(message);

            if (!isFinished)
                return;

            ClearOrderDetails();

            labelDeliveryStatus.Text = "Delivery status: ";
            labelDeliveryStatus.Visible = false;
            
            dataGridView1.Enabled = true;
            buttonTakeOrder.Text = "Take order";
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormCourierProfile(Location, ref courier);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }
        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }
    }
}
