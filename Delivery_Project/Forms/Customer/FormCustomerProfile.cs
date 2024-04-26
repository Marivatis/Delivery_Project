using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public FormCustomerProfile(Point formLocation) : base()
        {
            InitializeComponent();

            parentLocation = formLocation;
        }

        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            Location = parentLocation;
        }

        private void labelBecomeCourier_Click(object sender, EventArgs e)
        {
            formCourierRegisteration = new FormCourierRegisteration();
            formCourierRegisteration.FormClosed += Enable;

            Enabled = false;
            formCourierRegisteration.Show();
        }

        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void labelBecomeProvider_Click(object sender, EventArgs e)
        {
            formProviderRegistration = new FormProviderRegistration();
            formProviderRegistration.FormClosed += Enable;

            Enabled = false;
            formProviderRegistration.Show();
        }
    }
}
