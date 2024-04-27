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

namespace Delivery_Project.Forms.Customer
{
    public partial class FormCustomer : CustomBorderForm
    {
        private FormCustomerProfile formProfile;
        private FormOrderConfirmation formOrderConfirmation;

        private DeliveryCustomer customer;

        public FormCustomer(ref DeliveryCustomer customer) : base()
        {
            InitializeComponent();

            this.customer = customer;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            MessageBox.Show($"{customer.Login} {customer.Password} {customer.Address}");
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormCustomerProfile(Location);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            formOrderConfirmation = new FormOrderConfirmation(Location);
            formOrderConfirmation.FormClosed += Enable;

            Enabled = false;
            formOrderConfirmation.Show();
        }

        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }
    }
}
