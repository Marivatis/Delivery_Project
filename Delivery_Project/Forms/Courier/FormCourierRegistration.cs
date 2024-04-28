using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.DataControl.FormManagement;
using Delivery_Project.DataControl.Users;
using Delivery_Project.Forms.Templates;
using Microsoft.VisualBasic.Logging;

namespace Delivery_Project.Forms.Courier
{
    public partial class FormCourierRegistration : CustomBorderForm
    {
        private DeliveryCustomer customer;

        public static RegisterCourier? RegisterCourier;

        public static event Action<Type>? RegistrationComplete;

        public FormCourierRegistration(ref DeliveryCustomer customer) : base()
        {
            InitializeComponent();

            this.customer = customer;
        }

        private void FormCourierRegisteration_Load(object sender, EventArgs e)
        {
            if (customer.PhoneNumber != "No_Phone_Number")
                textBoxPhoneNumber.Text = customer.PhoneNumber;

            CenterToScreen();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxPhoneNumber.Text;
            string cardNumber = textBoxCardNumber.Text;

            if (phoneNumber == "Enter your phone number" || cardNumber == "Enter your card number")
            {
                labelMessage.Text = "Phone or card number fields are empty.";
                labelMessage.Visible = true;
                return;
            }

            try
            {
                customer.PhoneNumber = phoneNumber;
            }
            catch (InvalidDataException ex)
            {
                labelMessage.Text = ex.Message;
                labelMessage.Visible = true;
            }

            string message = "Something went wrong.";
            bool isRegistred = RegisterCourier?.Invoke(customer, cardNumber, ref message) ?? false;

            if (isRegistred)
            {
                RegistrationComplete?.Invoke(typeof(DeliveryCourier));
                Close();
                labelMessage.Text = "Ura";
                labelMessage.Visible = true;
            }
            else
            {
                labelMessage.Text = message;
                labelMessage.Visible = true;
            }
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

        // Field card number usefull design
        private void textBoxCardNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxCardNumber.Text == "Enter your card number")
            {
                textBoxCardNumber.Clear();
            }
        }
        private void textBoxCardNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCardNumber.Text)) 
            {
                textBoxCardNumber.Text = "Enter your card number";
            }
        }
    }
}
