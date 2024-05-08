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
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Provider
{
    public partial class FormProviderProfile : CustomBorderForm
    {
        private Point parentLocation;
        private DeliveryProvider provider;

        public static Func<DeliveryUser, bool>? DeleteAccount;

        public static event Action<Type>? AccountDeleted;

        public FormProviderProfile(Point formLocation, ref DeliveryProvider provider) : base()
        {
            InitializeComponent();

            this.provider = provider;
            parentLocation = formLocation;
        }

        // On load form functions
        private void FormProviderProfile_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = provider.Login;
            textBoxPassword.Text = provider.Password;
            textBoxPhoneNumber.Text = provider.PhoneNumber;

            Location = parentLocation;
        }

        // Login and phone number edit functionality
        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            switch(buttonEdit1.Text)
            {
                case "Edit":
                    buttonEdit1_Edit_Click();
                    break;
                case "Save":
                    buttonEdit1_Save_Click();
                    break;
            }
        }
        private void buttonEdit1_Edit_Click()
        {
            textBoxLogin.Enabled = true;
            textBoxPhoneNumber.Enabled = true;

            buttonEdit1.Text = "Save";
        }
        private void buttonEdit1_Save_Click()
        {
            try
            {
                if (provider.Login != textBoxLogin.Text)
                    provider.Login = textBoxLogin.Text;

                if (provider.PhoneNumber != textBoxPhoneNumber.Text)
                    provider.PhoneNumber = textBoxPhoneNumber.Text;

                textBoxLogin.Enabled = false;
                textBoxPhoneNumber.Enabled = false;

                buttonEdit1.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Password edit functionality
        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            switch (buttonEdit2.Text)
            {
                case "Edit":
                    buttonEdit2_Edit_Click();
                    break;
                case "Save":
                    buttonEdit2_Save_Click();
                    break;
            }
        }
        private void buttonEdit2_Edit_Click()
        {
            textBoxPassword.Enabled = true;

            buttonEdit2.Text = "Save";
        }
        private void buttonEdit2_Save_Click()
        {
            try
            {
                if (provider.Password != textBoxPassword.Text)
                    provider.Password = textBoxPassword.Text;

                textBoxPassword.Enabled = false;

                buttonEdit2.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Account delete button event handler
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete account?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            bool isDeleted = false;

            isDeleted = DeleteAccount?.Invoke(provider) ?? false;

            if (isDeleted)
            {
                MessageBox.Show("Account successfully deleted.");
                Close();
                AccountDeleted?.Invoke(typeof(DeliveryProvider));
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
