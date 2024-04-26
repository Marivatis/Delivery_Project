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

namespace Delivery_Project.Forms.Provider
{
    public partial class FormProviderRegistration : CustomBorderForm
    {
        public FormProviderRegistration() : base()
        {
            InitializeComponent();
        }

        private void FormProviderRegistration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
