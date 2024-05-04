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

namespace Delivery_Project.Forms.Customer
{
    public partial class FormCustomer : CustomBorderForm
    {
        private FormCustomerProfile formProfile;
        private FormOrderConfirmation formOrderConfirmation;

        private DeliveryCustomer customer;
        private List<DeliveryPlace> listPlaces;
        private DeliveryPlace? selectedPlace;
        private ProductCart productCart;
        private Product? selectedProduct;
        private Product? selectedProductInCart;
        private DeliveryOrderStatus? currentOrderStatus;

        public static Func<List<DeliveryPlace>?>? GetDeliveryPlacesList;
        public static DeclineOrder? DeclineOrder;
        public static Func<string, DeliveryOrder?>? GetActiveOrder;

        public FormCustomer(ref DeliveryCustomer customer) : base()
        {
            InitializeComponent();

            productCart = new ProductCart();
            ProductCart.CartChanged += ListBoxCart_Load;

            this.customer = customer;

            List<DeliveryPlace>? places = GetDeliveryPlacesList?.Invoke();

            if (places is null)
            {
                MessageBox.Show("Loading delivery places went wrong.");
                return;
            }

            listPlaces = places;

            OrdersManager.OrderStatusChanged += OrdersManager_OrderStatusChanged;
        }

        private void OrdersManager_OrderStatusChanged(object? sender, OrderStatusEventArgs e)
        {
            if (customer.Login != e.CustomerLogin)
                return;

            currentOrderStatus = e.Status;

            if (currentOrderStatus == DeliveryOrderStatus.Declined || currentOrderStatus == DeliveryOrderStatus.Delivered)
            {
                labelOrderStatus.Visible = false;
                buttonOrder.Text = "Order";
            }
            else
            {
                labelOrderStatus.Text = $"Order status: {currentOrderStatus}";
                labelOrderStatus.Visible = true;
                buttonOrder.Text = "Decline";
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            InitializeComboBox();
            Load_DataGridView();
            ListBoxCart_Load();

            LoadActiveOrder();
        }

        private void LoadActiveOrder()
        {
            DeliveryOrder? order = GetActiveOrder?.Invoke(customer.Login);

            if (order is null)
                return;

            comboBoxPlaces.SelectedItem = order.ProviderPlaceName;
            productCart = order.Cart;
            currentOrderStatus = order.OrderStatus;

            labelOrderStatus.Visible = true;
            labelOrderStatus.Text = $"Order status: {currentOrderStatus}";
            buttonOrder.Text = "Decline";

            ListBoxCart_Load();
        }

        private void InitializeComboBox()
        {
            foreach (var place in listPlaces)
            {
                comboBoxPlaces.Items.Add(place.Name);
            }

            comboBoxPlaces.SelectedIndexChanged += ComboBoxPlaces_SelectedIndexChanged;

            comboBoxPlaces.SelectedIndex = 0;
        }
        private void Load_DataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedPlace?.Menu.List;
            dataGridView1.ClearSelection();

            dataGridView1.Columns["Name"].HeaderText = "Product";
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Price"].Width = 100;
            dataGridView1.Columns["Description"].Width = 407;
        }
        private void ListBoxCart_Load()
        {
            listBoxCart.Items.Clear();

            foreach (var key in productCart.Cart)
            {
                listBoxCart.Items.Add(productCart.KeyToString(key));
            }

            labelProductPrice.Text = $"Products price: {productCart.ProductPrice} UAH";
            labelTotalPrice.Text = $"Total price: {productCart.ProductPrice + selectedPlace?.DeliveryPrice} UAH";
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddProductToCart(selectedProduct);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProductToCart(selectedProductInCart);
        }
        private void AddProductToCart(Product? product)
        {
            if (product is null)
            {
                MessageBox.Show("There is no selected product to add.");
                return;
            }

            productCart.Add(product);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (selectedProductInCart is null)
            {
                MessageBox.Show("There is no selected product to add.");
                return;
            }

            productCart.Remove(selectedProductInCart);
        }

        private void ListBoxCart_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedProductInCartName = GetProductNameFromCart(listBoxCart.SelectedItem?.ToString());

            selectedProductInCart = selectedPlace?.Menu.First(p => p.Name == selectedProductInCartName);
        }
        private string GetProductNameFromCart(string? listBoxString)
        {
            if (string.IsNullOrEmpty(listBoxString))
                return string.Empty;

            string[] stringSplit = listBoxString.Split(' ');

            string productName = string.Empty;

            for (int i = 1; i < stringSplit.Length; i++)
            {
                productName += stringSplit[i] + ' ';
            }

            return productName.Substring(0, productName.Length - 2);
        }

        private void ComboBoxPlaces_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedPlaceName = comboBoxPlaces.SelectedItem.ToString();

            if (selectedPlaceName is null)
            {
                MessageBox.Show("Selecting comboBox item went wrong.");
                return;
            }

            selectedPlace = listPlaces.FirstOrDefault(p => p.Name == selectedPlaceName);

            if (selectedPlace is null)
            {
                MessageBox.Show($"No place with name {selectedPlaceName} in places list.");
                return;
            }

            labelPlaceName.Text = selectedPlace.Name;
            labelPlaceAddress.Text = selectedPlace.Address;
            labelPlaceDescription.Text = selectedPlace.Description;

            labelDeliveryPrice.Text = $"Delivery price: {selectedPlace?.DeliveryPrice} UAH";
            labelPlaceDeliveryPrice.Text = $"Delivery price: {selectedPlace?.DeliveryPrice} UAH";

            productCart.Clear();

            Load_DataGridView();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return;

            selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

            if (selectedProduct is null)
                return;
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormCustomerProfile(Location, ref customer);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (buttonOrder.Text == "Order")
                buttonOrder_Order_Click();
            else if (buttonOrder.Text == "Decline")
                buttonOrder_Decline_Click();
        }
        private void buttonOrder_Order_Click()
        {
            if (selectedPlace is null)
            {
                MessageBox.Show("Select delivery place before making order.");
                return;
            }

            if (productCart.Count == 0)
            {
                MessageBox.Show("Add some products to your cart before making order.");
                return;
            }

            formOrderConfirmation = new FormOrderConfirmation(Location, selectedPlace, customer, productCart);
            formOrderConfirmation.FormClosed += Enable;
            formOrderConfirmation.FormClosed += FormOrderConfirmation_FormClosed;

            Enabled = false;
            formOrderConfirmation.Show();
        }
        private void buttonOrder_Decline_Click()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to decline order?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if (currentOrderStatus is null)
            {
                MessageBox.Show("You don't have any orders to decline now.");
                return;
            }

            if (currentOrderStatus == DeliveryOrderStatus.OnTheWay)
            {
                MessageBox.Show("You can`t decline order when it`s on the way.");
                return;
            }
            string message = "Something went wrong.";
            bool isDeclined = DeclineOrder?.Invoke(customer.Login, ref message) ?? false;

            if (!isDeclined)
            {
                MessageBox.Show(message);
                return;
            }

            currentOrderStatus = DeliveryOrderStatus.Declined;

            currentOrderStatus = null;
            selectedProductInCart = null;
            productCart.Clear();
            ListBoxCart_Load();

            labelOrderStatus.Visible = false;
            labelOrderStatus.Text = "Order status: ";
            buttonOrder.Text = "Order";
        }

        private void FormOrderConfirmation_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }
    }
}
