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
    public partial class FormCourier : CustomBorderForm
    {
        private FormCourierProfile formProfile;

        private DeliveryCourier courier;

        public FormCourier(ref DeliveryCourier courier) : base()
        {
            InitializeComponent();

            this.courier = courier;
        }

        private void FormCourier_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormCourierProfile(Location);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }

        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }
    }
}
