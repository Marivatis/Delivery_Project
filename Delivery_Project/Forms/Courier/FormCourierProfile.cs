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

namespace Delivery_Project.Forms.Courier
{
    public partial class FormCourierProfile : CustomBorderForm
    {
        private Point parentLocation;
        private DeliveryCourier courier;

        public static Func<DeliveryUser, bool>? DeleteAccount;

        public static event Action<Type>? AccountDeleted;

        public FormCourierProfile(Point formLocation, ref DeliveryCourier courier) : base()
        {
            InitializeComponent();

            this.courier = courier;
            parentLocation = formLocation;
        }

        // On load form functions
        private void FormCourierProfile_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = courier.Login;
            textBoxPassword.Text = courier.Password;
            textBoxPhoneNumber.Text = courier.PhoneNumber;
            textBoxCardNumber.Text = courier.CardNumber;

            Location = parentLocation;
        }

        // Login and phone number edit functionality
        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            if (buttonEdit1.Text == "Edit")
            {
                buttonEdit1_Edit_Click();
            }
            else if (buttonEdit1.Text == "Save")
            {
                buttonEdit1_Save_Click();
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
                courier.Login = textBoxLogin.Text;
                courier.PhoneNumber = textBoxPhoneNumber.Text;

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
            if (buttonEdit2.Text == "Edit")
            {
                buttonEdit2_Edit_Click();
            }
            else if (buttonEdit2.Text == "Save")
            {
                buttonEdit2_Save_Click();
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
                courier.Password = textBoxPassword.Text;

                textBoxPassword.Enabled = false;

                buttonEdit2.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Card number edit functionality
        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            if (buttonEdit3.Text == "Edit")
            {
                buttonEdit3_Edit_Click();
            }
            else if (buttonEdit3.Text == "Save")
            {
                buttonEdit3_Save_Click();
            }
        }
        private void buttonEdit3_Edit_Click()
        {
            textBoxCardNumber.Enabled = true;

            buttonEdit3.Text = "Save";
        }
        private void buttonEdit3_Save_Click()
        {
            try
            {
                courier.CardNumber = textBoxCardNumber.Text;

                textBoxCardNumber.Enabled = false;

                buttonEdit3.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Makes account delete querry
        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete account?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            bool isDeleted = false;

            isDeleted = DeleteAccount?.Invoke(courier) ?? false;

            if (isDeleted)
            {
                MessageBox.Show("Account successfully deleted.");
                Close();
                AccountDeleted?.Invoke(typeof(DeliveryCourier));
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
