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

namespace Delivery_Project.Forms.Entry
{
    public partial class FormRegistration : CustomBorderForm
    {
        public event EventHandler LoginComplete;

        public FormRegistration() : base()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBoxLogin.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            LoginComplete?.Invoke(this, EventArgs.Empty);
        }
    }
}
