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
    public partial class FormCustomer : TemplateCustomBorderForm
    {
        private FormCustomerProfile? _formProfile;
        private FormOrderConfirmation? _formOrderConfirmation;

        private DeliveryCustomer _customer;
        private List<DeliveryPlace> _listPlaces;
        private ProductCart _productCart;

        private DeliveryPlace? _selectedPlace;
        private Product? _selectedProduct;
        private Product? _selectedProductInCart;
        private DeliveryOrderStatus? _currentOrderStatus;

        public static Func<List<DeliveryPlace>?>? GetDeliveryPlacesList;
        public static DeclineOrder? DeclineOrder;
        public static Func<string, DeliveryOrder?>? GetActiveOrder;

        public FormCustomer(ref DeliveryCustomer customer) : base()
        {
            InitializeComponent();

            List<DeliveryPlace>? places = GetDeliveryPlacesList?.Invoke();

            _listPlaces = places ?? new List<DeliveryPlace>();
            _productCart = new ProductCart();
            _customer = customer;

            ProductCart.CartChanged += ListBoxCart_Load;
            OrdersManager.OrderStatusChanged += OrdersManager_OrderStatusChanged;
        }

        // Current order status changed event handler
        private void OrdersManager_OrderStatusChanged(object? sender, OrderStatusEventArgs e)
        {
            if (_customer.Login != e.CustomerLogin)
                return;

            _currentOrderStatus = e.Status;

            if (_currentOrderStatus == DeliveryOrderStatus.Declined || _currentOrderStatus == DeliveryOrderStatus.Delivered)
            {
                labelOrderStatus.Visible = false;
                buttonMakeOrder.Text = "Order";
            }
            else
            {
                labelOrderStatus.Text = $"Order status: {_currentOrderStatus}";
                labelOrderStatus.Visible = true;
                buttonMakeOrder.Text = "Decline";
            }
        }

        // On load form functions
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (_listPlaces.Count != 0)
            {
                ComboBoxPlaces_Load(_listPlaces);
            }

            if (_selectedPlace != null)
            {
                DataGridView_Load(_selectedPlace);
                ListBoxCart_Load(_productCart, _selectedPlace);
            }

            DeliveryOrder? order = GetActiveOrder?.Invoke(_customer.Login);

            if (order is null)
                return;

            ActiveOrder_Load(order);
        }
        // Initializes comboBox using given list of places
        private void ComboBoxPlaces_Load(List<DeliveryPlace> places)
        {
            foreach (var place in places)
            {
                comboBoxPlacesList.Items.Add(place.Name);
            }

            comboBoxPlacesList.SelectedIndexChanged += ComboBoxPlaces_SelectedIndexChanged;

            comboBoxPlacesList.SelectedIndex = 0;
        }
        // Loads selected place info using given place
        private void DataGridView_Load(DeliveryPlace place)
        {
            dataGridViewPlaceMenu.DataSource = null;
            dataGridViewPlaceMenu.DataSource = place.Menu.ToList();
            dataGridViewPlaceMenu.ClearSelection();

            dataGridViewPlaceMenu.Columns["Name"].HeaderText = "Product";
            dataGridViewPlaceMenu.Columns["Name"].Width = 150;
            dataGridViewPlaceMenu.Columns["Price"].Width = 100;
            dataGridViewPlaceMenu.Columns["Description"].Width = 407;
        }
        // Loads cart info using _productCart and _selectedPlace fields
        private void ListBoxCart_Load()
        {
            if (_selectedPlace is null)
            {
                MessageBox.Show("Failed to load listBoxCart info from _selectedPlace");
                return;
            }

            DeliveryPlace place = _selectedPlace;

            ListBoxCart_Load(_productCart, _selectedPlace);
        }
        // Loads cart info using given cart and place
        private void ListBoxCart_Load(ProductCart cart, DeliveryPlace place)
        {
            listBoxCustomerCart.Items.Clear();

            foreach (var key in cart.Cart)
            {
                listBoxCustomerCart.Items.Add(cart.KeyToString(key));
            }

            labelDeliveryPercent.Text = $"Delivery percent: {cart.ProductPrice * place.DeliveryPercent / 100.0} UAH";
            labelProductPrice.Text = $"Products price: {cart.ProductPrice} UAH";
            labelTotalPrice.Text = $"Total price: {cart.ProductPrice + place?.DeliveryPrice} UAH";
        }
        // Loads active customer order if it exists
        private void ActiveOrder_Load(DeliveryOrder order)
        {
            comboBoxPlacesList.SelectedItem = order.ProviderPlaceName;
            _productCart = order.OrderCart;
            _currentOrderStatus = order.OrderStatus;

            labelOrderStatus.Visible = true;
            labelOrderStatus.Text = $"Order status: {_currentOrderStatus}";
            buttonMakeOrder.Text = "Decline";

            CartFunctions_Enable(false);

            ListBoxCart_Load();
        }

        // Adds selected in menu product to cart
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddProductToCart(_selectedProduct);
        }
        // Adds selected in cart product to cart
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProductToCart(_selectedProductInCart);
        }
        // Adds given product to product cart
        private void AddProductToCart(Product? product)
        {
            if (product is null)
            {
                MessageBox.Show("There is no selected product to add.");
                return;
            }

            _productCart.Add(product);
        }

        // Removes selected product from product cart
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_selectedProductInCart is null)
            {
                MessageBox.Show("There is no selected product to remove.");
                return;
            }

            _productCart.Remove(_selectedProductInCart);
        }

        // Changes selectedProductInCart on selected product in list box
        private void ListBoxCart_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedProductInCartName = GetProductNameFromCart(listBoxCustomerCart.SelectedItem?.ToString());

            _selectedProductInCart = _selectedPlace?.Menu.First(p => p.Name == selectedProductInCartName);
        }
        // Changes place info depending on selected place
        private void ComboBoxPlaces_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedPlaceName = comboBoxPlacesList.SelectedItem.ToString();

            if (selectedPlaceName is null)
            {
                MessageBox.Show("Selecting comboBox item went wrong.");
                return;
            }

            _selectedPlace = _listPlaces.FirstOrDefault(p => p.Name == selectedPlaceName);

            if (_selectedPlace is null)
            {
                MessageBox.Show($"No place with name {selectedPlaceName} in places list.");
                return;
            }

            labelPlaceName.Text = _selectedPlace.Name;
            labelPlaceAddress.Text = _selectedPlace.Address;
            labelPlaceDescription.Text = _selectedPlace.Description;

            labelDeliveryPrice.Text = $"Delivery price: {_selectedPlace.DeliveryPrice} UAH";
            labelPlaceDeliveryPrice.Text = $"Delivery price: {_selectedPlace.DeliveryPrice} UAH | Delivery persent: {_selectedPlace.DeliveryPercent}%";

            ClearCartInfo();

            DataGridView_Load(_selectedPlace);
        }
        // Product selection depending on DataGridView cell click
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewPlaceMenu.Rows.Count)
                return;

            _selectedProduct = dataGridViewPlaceMenu.Rows[e.RowIndex].DataBoundItem as Product;

            if (_selectedProduct is null)
                return;
        }

        // Shows customer profile form as a dialog
        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            _formProfile = new FormCustomerProfile(Location, ref _customer);
            _formProfile.ShowDialog();
        }

        // Order button switch depending on it`s text
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            switch (buttonMakeOrder.Text)
            {
                case "Order":
                    buttonOrder_Order_Click();
                    break;
                case "Decline":
                    buttonOrder_Decline_Click();

                    ClearLabelOrderStatus();
                    buttonMakeOrder.Text = "Order";
                    break;
            }
        }
        // Prepares data and shows order confirmation dialog
        private void buttonOrder_Order_Click()
        {
            if (_selectedPlace is null)
            {
                MessageBox.Show("Select delivery place before making order.");
                return;
            }

            if (_productCart.Count == 0)
            {
                MessageBox.Show("Add some products to your cart before making order.");
                return;
            }

            _formOrderConfirmation = new FormOrderConfirmation(Location, _selectedPlace, _customer, _productCart);
            _formOrderConfirmation.ShowDialog();

            if (_currentOrderStatus != null)
                CartFunctions_Enable(false);
        }
        // Declines customer`s current order 
        private void buttonOrder_Decline_Click()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to decline order?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if (_currentOrderStatus is null)
            {
                MessageBox.Show("You don't have any orders to decline now.");
                return;
            }

            if (_currentOrderStatus == DeliveryOrderStatus.OnTheWay)
            {
                MessageBox.Show("You can`t decline order when it`s on the way.");
                return;
            }

            string message = "Something went wrong.";
            bool isDeclined = DeclineOrder?.Invoke(_customer.Login, ref message) ?? false;

            if (!isDeclined)
            {
                MessageBox.Show(message);
                return;
            }

            _currentOrderStatus = DeliveryOrderStatus.Declined;
            ClearCartInfo();

            CartFunctions_Enable(true);
        }

        // Clears all cart info
        private void ClearCartInfo()
        {
            _currentOrderStatus = null;
            _selectedProductInCart = null;
            _productCart.Clear();
            ListBoxCart_Load();
        }
        // Clears and hides order status label
        private void ClearLabelOrderStatus()
        {
            labelOrderStatus.Visible = false;
            labelOrderStatus.Text = "Order status: ";
        }

        // Changes main cart functionality Enable property depending on given enable
        private void CartFunctions_Enable(bool enable)
        {
            comboBoxPlacesList.Enabled = enable;

            buttonAddCartProduct.Enabled = enable;
            buttonRemoveCartProduct.Enabled = enable;
            buttonAddToCart.Enabled = enable;
        }
        // Returns product name from single listBoxString
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
    }
}
