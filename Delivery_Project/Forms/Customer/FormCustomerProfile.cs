﻿using System;
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
using Delivery_Project.Forms.Courier;
using Delivery_Project.Forms.Provider;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Customer
{
    public partial class FormCustomerProfile : CustomBorderForm
    {
        private FormCourierRegisteration formCourierRegisteration;
        private FormProviderRegistration formProviderRegistration;

        private Point parentLocation;
        private DeliveryCustomer customer;

        public static Func<DeliveryUser, bool>? DeleteAccount;

        public static event Action<Type>? AccountDeleted;

        public FormCustomerProfile(Point formLocation, ref DeliveryCustomer customer) : base()
        {
            InitializeComponent();

            this.customer = customer;
            parentLocation = formLocation;
        }

        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            LoadComponent();

            Location = parentLocation;
        }

        private void labelBecomeCourier_Click(object sender, EventArgs e)
        {
            formCourierRegisteration = new FormCourierRegisteration();
            formCourierRegisteration.FormClosed += Enable;

            Enabled = false;
            formCourierRegisteration.Show();
        }
        private void labelBecomeProvider_Click(object sender, EventArgs e)
        {
            formProviderRegistration = new FormProviderRegistration();
            formProviderRegistration.FormClosed += Enable;

            Enabled = false;
            formProviderRegistration.Show();
        }
        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void LoadComponent()
        {
            textBoxLogin.Text = customer.Login;
            textBoxPhoneNumber.Text = customer.PhoneNumber;
            textBoxPassword.Text = customer.Password;
            textBoxAddress.Text = customer.Address;
        }

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
                customer.Login = textBoxLogin.Text;
                customer.PhoneNumber = textBoxPhoneNumber.Text;

                textBoxLogin.Enabled = false;
                textBoxPhoneNumber.Enabled = false;

                buttonEdit1.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
                customer.Password = textBoxPassword.Text;

                textBoxPassword.Enabled = false;

                buttonEdit2.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

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
            textBoxPassword.Enabled = true;

            buttonEdit3.Text = "Save";
        }
        private void buttonEdit3_Save_Click()
        {
            try
            {
                customer.Address = textBoxAddress.Text;

                textBoxPassword.Enabled = false;

                buttonEdit3.Text = "Edit";
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            bool isDeleted = false;

            isDeleted = DeleteAccount?.Invoke(customer) ?? false;

            if (isDeleted)
            {
                MessageBox.Show("Account successfully deleted.");
                Close();
                AccountDeleted?.Invoke(typeof(DeliveryCustomer));
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
