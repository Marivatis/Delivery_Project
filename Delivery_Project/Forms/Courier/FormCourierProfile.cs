using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Courier
{
    public partial class FormCourierProfile : CustomBorderForm
    {
        private Point parentLocation;

        public FormCourierProfile(Point formLocation) : base()
        {
            InitializeComponent();
            parentLocation = formLocation;
        }

        private void FormCourierProfile_Load(object sender, EventArgs e)
        {
            Location = parentLocation;
        }
    }
}
