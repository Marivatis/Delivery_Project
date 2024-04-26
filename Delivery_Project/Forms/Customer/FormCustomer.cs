using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.Forms.CustomBorderCode;

namespace Delivery_Project.Forms.Customer
{
    public partial class FormCustomer : CustomBorderForm
    {
        private FormCustomerProfile formProfile;
        private FormOrderConfirmation formOrderConfirmation;

        public FormCustomer() : base()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CenterToScreen();
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
