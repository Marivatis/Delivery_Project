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
    public partial class FormCustomerProfile : CustomBorderForm
    {
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
    }
}
