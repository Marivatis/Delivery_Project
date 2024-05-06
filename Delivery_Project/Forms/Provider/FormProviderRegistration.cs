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

namespace Delivery_Project.Forms.Provider
{
    public partial class FormProviderRegistration : CustomBorderForm
    {
        private DeliveryUser user;

        public static RegisterProvider? RegisterProvider;

        public static event Action<Type>? RegistrationComplete;

        public FormProviderRegistration(DeliveryUser user) : base()
        {
            InitializeComponent();

            this.user = user;
        }

        // On load form functions
        private void FormProviderRegistration_Load(object sender, EventArgs e)
        {
            if (user.PhoneNumber != "No_Phone_Number")
            {
                textBoxPhoneNumber.Text = user.PhoneNumber;
            }

            textBoxPhoneNumber.Focus();
            CenterToScreen();
        }

        // Registration button click event hendler
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxPhoneNumber.Text;
            string secretWord = textBoxSecretWord.Text;

            if (phoneNumber == "Enter your phone number" || secretWord == "Enter secret word")
            {
                labelMessage.Text = "Phone or secret word fields are empty.";
                labelMessage.Visible = true;
                return;
            }

            try
            {
                user.PhoneNumber = phoneNumber;
            }
            catch (InvalidDataException ex)
            {
                labelMessage.Text = ex.Message;
                labelMessage.Visible = true;
            }

            string message = "Something went wrong.";
            bool isRegistred = RegisterProvider?.Invoke(user, secretWord, ref message) ?? false;

            if (isRegistred)
            {
                RegistrationComplete?.Invoke(typeof(DeliveryProvider));
                Close();
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

        // Fieald secret word usefull design
        private void textBoxSecretWord_Enter(object sender, EventArgs e)
        {
            if (textBoxSecretWord.Text == "Enter secret word")
            {
                textBoxSecretWord.Clear();
            }
        }
        private void textBoxSecretWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSecretWord.Text))
            {
                textBoxSecretWord.Text = "Enter secret word";
            }
        }
    }
}
