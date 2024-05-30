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
    public partial class FormCourierProfile : TemplateCustomBorderForm
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

            if (FormCourier.WorkStatus)
            {
                buttonWorkStatus.Text = "End Work";
            }

            Location = parentLocation;
        }

        // Login and phone number edit functionality
        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            if (buttonEditLoginPhone.Text == "Edit")
            {
                buttonEdit1_Edit_Click();
            }
            else if (buttonEditLoginPhone.Text == "Save")
            {
                buttonEdit1_Save_Click();
            }
        }
        private void buttonEdit1_Edit_Click()
        {
            textBoxLogin.Enabled = true;
            textBoxPhoneNumber.Enabled = true;

            buttonEditLoginPhone.Text = "Save";
        }
        private void buttonEdit1_Save_Click()
        {
            try
            {
                if (courier.Login != textBoxLogin.Text)
                    courier.Login = textBoxLogin.Text;

                if (courier.PhoneNumber != textBoxPhoneNumber.Text)
                    courier.PhoneNumber = textBoxPhoneNumber.Text;

                textBoxLogin.Enabled = false;
                textBoxPhoneNumber.Enabled = false;

                buttonEditLoginPhone.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Password edit functionality
        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            if (buttonEditPassword.Text == "Edit")
            {
                buttonEdit2_Edit_Click();
            }
            else if (buttonEditPassword.Text == "Save")
            {
                buttonEdit2_Save_Click();
            }
        }
        private void buttonEdit2_Edit_Click()
        {
            textBoxPassword.Enabled = true;

            buttonEditPassword.Text = "Save";
        }
        private void buttonEdit2_Save_Click()
        {
            try
            {

                if (courier.Password != textBoxPassword.Text)
                    courier.Password = textBoxPassword.Text;

                textBoxPassword.Enabled = false;

                buttonEditPassword.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Card number edit functionality
        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            if (buttonEditCardNumber.Text == "Edit")
            {
                buttonEdit3_Edit_Click();
            }
            else if (buttonEditCardNumber.Text == "Save")
            {
                buttonEdit3_Save_Click();
            }
        }
        private void buttonEdit3_Edit_Click()
        {
            textBoxCardNumber.Enabled = true;

            buttonEditCardNumber.Text = "Save";
        }
        private void buttonEdit3_Save_Click()
        {
            try
            {
                if (courier.CardNumber != textBoxCardNumber.Text)
                    courier.CardNumber = textBoxCardNumber.Text;

                textBoxCardNumber.Enabled = false;

                buttonEditCardNumber.Text = "Edit";
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

        private void buttonWorkStatus_Click(object sender, EventArgs e)
        {
            if (buttonWorkStatus.Text == "Start Work")
            {
                FormCourier.WorkStatus = true;
                buttonWorkStatus.Text = "End Work";
            }
            else if (buttonWorkStatus.Text == "End Work")
            {
                FormCourier.WorkStatus = false;
                buttonWorkStatus.Text = "Start Work";
            }
        }
    }
}
