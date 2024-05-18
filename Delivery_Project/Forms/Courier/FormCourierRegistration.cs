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
    public partial class FormCourierRegistration : TemplateCustomBorderForm
    {
        private DeliveryUser user;

        public static RegisterCourier? RegisterCourier;

        public static event Action<Type>? RegistrationComplete;

        public FormCourierRegistration(DeliveryUser user) : base()
        {
            InitializeComponent();

            this.user = user;
        }

        // On load form functions
        private void FormCourierRegisteration_Load(object sender, EventArgs e)
        {
            if (user.PhoneNumber != "No_Phone_Number")
                textBoxPhoneNumber.Text = user.PhoneNumber;

            CenterToScreen();
        }

        // Registration button click event hendler
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxPhoneNumber.Text;
            string cardNumber = textBoxCardNumber.Text;

            if (phoneNumber == "Enter your phone number" || cardNumber == "Enter your card number")
            {
                labelInformingMessage.Text = "Phone or card number fields are empty.";
                labelInformingMessage.Visible = true;
                return;
            }

            try
            {
                user.PhoneNumber = phoneNumber;
            }
            catch (InvalidDataException ex)
            {
                labelInformingMessage.Text = ex.Message;
                labelInformingMessage.Visible = true;
            }

            string message = "Something went wrong.";
            bool isRegistred = RegisterCourier?.Invoke(user, cardNumber, ref message) ?? false;

            if (isRegistred)
            {
                RegistrationComplete?.Invoke(typeof(DeliveryCourier));
                Close();
            }
            else
            {
                labelInformingMessage.Text = message;
                labelInformingMessage.Visible = true;
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
