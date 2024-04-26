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
    public partial class FormProvider : CustomBorderForm
    {
        private FormProviderProfile formProfile;
        private FormPlaceEditor formPlaceEditor;

        public FormProvider() : base()
        {
            InitializeComponent();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormProviderProfile(Location);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }

        private void Enable(object? sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void buttonEditPlace_Click(object sender, EventArgs e)
        {
            formPlaceEditor = new FormPlaceEditor();
            formPlaceEditor.FormClosed += Enable;

            Enabled = false;
            formPlaceEditor.Show();
        }
    }
}
