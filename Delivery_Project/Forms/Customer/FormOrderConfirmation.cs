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
        private Point parentLocation;
        private DeliveryOrder order;
        private DeliveryPlace place;
        private DeliveryCustomer customer;
        private ProductCart productCart;
        private int totalPrice;

        public static OrderHandler? MakeOrder;

        public FormOrderConfirmation(Point formLocation, DeliveryPlace place, DeliveryCustomer customer, ProductCart cart) : base()
        {
            InitializeComponent();

            parentLocation = formLocation;
            this.place = place;
            this.customer = customer;
            productCart = cart;
            totalPrice = cart.ProductPrice + place.DeliveryPrice;
        }


        private void FormOrderConfirmation_Load(object sender, EventArgs e)
        {
            Load_Cart();

            textBoxPhoneNumber.Text = customer.PhoneNumber;
            textBoxAddress.Text = customer.Address;

            labelTotalPrice.Text = $"Total price: {totalPrice} UAH";

            Location = parentLocation;
        }
        private void Load_Cart()
        {
            listBoxCart.Items.Clear();

            foreach (var key in productCart.Cart)
            {
                listBoxCart.Items.Add(productCart.KeyToString(key));
            }
        }

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
                customer.PhoneNumber = textBoxPhoneNumber.Text;
                customer.Address = textBoxAddress.Text;
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            order = new DeliveryOrder(customer, place, productCart);

            string message = "Something went wrong";
            bool isMade = MakeOrder?.Invoke(order, ref message) ?? false;

            if (!isMade)
            {
                MessageBox.Show(message);
                return;
            }

            Close();
        }

        public DeliveryOrder? GetOrder()
        {
            return order;
        }

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
