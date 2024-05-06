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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Delivery_Project.Forms.Courier
{
    public partial class FormCourier : CustomBorderForm
    {
        private FormCourierProfile? formProfile;

        private DeliveryCourier _courier;

        private DeliveryOrder? _selectedOrder;
        private List<DeliveryOrder>? _waitingOrdersList;

        public static Func<List<DeliveryOrder>?>? GetWaitingOrdersList;
        public static Func<string, DeliveryOrder?>? GetTakenOrder;
        public static Func<string, bool>? OrderOnTheWay;
        public static TakeOrder? TakeOrder;
        public static FinishOrder? FinishOrder;

        public FormCourier(ref DeliveryCourier courier) : base()
        {
            InitializeComponent();

            this._courier = courier;
        }

        // On load form functions
        private void FormCourier_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            DataGridView_Load();
            TakenOrder_Load();
        }
        private void DataGridView_Load()
        {
            _waitingOrdersList = GetWaitingOrdersList?.Invoke();

            if (_waitingOrdersList is null)
                return;

            dataGridView1.Rows.Clear();

            foreach (var order in _waitingOrdersList)
            {
                dataGridView1.Rows.Add(order.CourierEarning, order.CustomerAddress, order.ProviderPlaceAddress);
            }

            dataGridView1.ClearSelection();
        }
        private void TakenOrder_Load()
        {
            DeliveryOrder? order = GetTakenOrder?.Invoke(_courier.Login);

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

            _selectedOrder = order;
        }

        // Order selection depending on DataGridView cell click
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int earning = Convert.ToInt32(row.Cells["Earning"].Value);
            string customerAddress = row.Cells["DestinationAddress"].Value.ToString() ?? string.Empty;
            string providerPlaceAddress = row.Cells["ProviderAdress"].Value.ToString() ?? string.Empty;

            _selectedOrder = FindOrder(earning, customerAddress, providerPlaceAddress);

            if (_selectedOrder is null)
                return;

            ShowOrderDetails(_selectedOrder);
        }

        // Find order in orders list using given info
        private DeliveryOrder? FindOrder(int earning, string customerAddress, string providerPlaceAddress)
        {
            return _waitingOrdersList?.FirstOrDefault(o => o.CourierEarning == earning &&
                                                           o.CustomerAddress == customerAddress &&
                                                           o.ProviderPlaceAddress == providerPlaceAddress);
        }

        // Shows all selected order details on form
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
        // Clears all selected order details on form
        private void ClearOrderDetails()
        {
            _waitingOrdersList?.Clear();
            listBoxOrderDetails.Text = string.Empty;
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

        // Rehreshes _waitingOrdersList and DataGridView
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataGridView_Load();

            if (_selectedOrder?.OrderStatus == DeliveryOrderStatus.Accepted || _selectedOrder?.OrderStatus == DeliveryOrderStatus.OnTheWay)
                return;

            ClearOrderDetails();
        }

        // Order delivery handler unit
        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            switch (buttonTakeOrder.Text)
            {
                case "Take order":
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
            if (_selectedOrder is null)
            {
                MessageBox.Show("Select some order before.");
                return;
            }

            string message = "Something went wrong";

            bool isTaken = TakeOrder?.Invoke(_selectedOrder, _courier, ref message) ?? false;

            if (!isTaken)
            {
                MessageBox.Show(message);
                return;
            }

            TakenOrder_Load();

            _waitingOrdersList?.Remove(_selectedOrder);
            DataGridView_Load();
        }
        private void buttonTakeOrder_OnTheWay_Click()
        {
            bool isOnTheWay = OrderOnTheWay?.Invoke(_courier.Login) ?? false;

            if (!isOnTheWay)
            {
                MessageBox.Show("Something went wrong.");
                return;
            }

            _selectedOrder.OrderStatus = DeliveryOrderStatus.OnTheWay;

            labelDeliveryStatus.Text = $"Delivery status: {_selectedOrder.OrderStatus}";
            labelDeliveryStatus.Visible = true;

            buttonTakeOrder.Text = "Finish delivery";
        }
        private void buttonTakeOrder_FinishDelivery_Click()
        {
            string message = "Something went wrong.";

            bool isFinished = FinishOrder?.Invoke(_courier.Login, ref message) ?? false;

            MessageBox.Show(message);

            if (!isFinished)
                return;

            ClearOrderDetails();

            labelDeliveryStatus.Text = "Delivery status: ";
            labelDeliveryStatus.Visible = false;
            
            dataGridView1.Enabled = true;
            buttonTakeOrder.Text = "Take order";
        }

        // Transition to profile form
        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormCourierProfile(Location, ref _courier);
            formProfile.ShowDialog();
        }
    }
}
