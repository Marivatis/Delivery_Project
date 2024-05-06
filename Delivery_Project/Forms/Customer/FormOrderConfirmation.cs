using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.DataControl.Users;
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.Forms.Templates;
using Delivery_Project.DataControl.Workplaces.Management;

namespace Delivery_Project.Forms.Customer
{
    public partial class FormOrderConfirmation : CustomBorderForm
    {
        private Point _parentLocation;

        private DeliveryOrder _order;
        private DeliveryPlace _place;
        private DeliveryCustomer _customer;
        private ProductCart _productCart;
        private int _totalPrice;

        public static OrderHandler? MakeOrder;

        public FormOrderConfirmation(Point formLocation, DeliveryPlace place, DeliveryCustomer customer, ProductCart cart) : base()
        {
            InitializeComponent();

            _parentLocation = formLocation;
            this._place = place;
            this._customer = customer;
            _productCart = cart;
            _totalPrice = cart.ProductPrice + place.DeliveryPrice;
        }

        // On load form functions
        private void FormOrderConfirmation_Load(object sender, EventArgs e)
        {
            ListBoxCart_Load();

            textBoxPhoneNumber.Text = _customer.PhoneNumber;
            textBoxAddress.Text = _customer.Address;

            labelTotalPrice.Text = $"Total price: {_totalPrice} UAH";

            Location = _parentLocation;
        }
        // Loads cart info using _productCart field
        private void ListBoxCart_Load()
        {
            listBoxCart.Items.Clear();

            foreach (var key in _productCart.Cart)
            {
                listBoxCart.Items.Add(_productCart.KeyToString(key));
            }
        }

        // Makes order querry
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "Enter your phone number" || textBoxAddress.Text == "Enter your address")
            {
                MessageBox.Show("Phone number or address field are empty.");
                return;
            }

            if (textBoxAddress.Text == "No_Address")
            {
                MessageBox.Show("You must etner your address to make order.");
                return;
            }

            try
            {
                _customer.PhoneNumber = textBoxPhoneNumber.Text;
                _customer.Address = textBoxAddress.Text;
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _order = new DeliveryOrder(_customer, _place, _productCart);

            string message = "Something went wrong";
            bool isMade = MakeOrder?.Invoke(_order, ref message) ?? false;

            if (!isMade)
            {
                MessageBox.Show(message);
                return;
            }

            Close();
        }

        // Field phone number usefull design
        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "Enter your phone number")
            {
                textBoxPhoneNumber.Clear();
            }
        }
        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                textBoxPhoneNumber.Text = "Enter your phone number";
            }
        }

        // Field address usefull design
        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Enter your address")
            {
                textBoxAddress.Clear();
            }
        }
        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                textBoxAddress.Text = "Enter your address";
            }
        }
    }
}
