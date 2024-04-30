using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Provider
{
    public partial class FormPlaceEditor : CustomBorderForm
    {
        private DeliveryPlace place;

        public FormPlaceEditor(ref DeliveryPlace place) : base()
        {
            InitializeComponent();

            this.place = place;
        }

        private void FormPlaceEditor_Load(object sender, EventArgs e)
        {
            textBoxPlaceName.Text = place.Name;
            textBoxAddress.Text = place.Address;
            richTextBox1.Text = place.Description;

            CenterToScreen();
        }

        // Saves data from text boxes to corresponding place
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                place.Name = textBoxPlaceName.Text;
                place.Address = textBoxAddress.Text;
                place.Description = richTextBox1.Text;
                
                Close();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Field place nameusefull design
        private void textBoxPlaceName_Enter(object sender, EventArgs e)
        {
            if (textBoxPlaceName.Text == "Enter place name")
            {
                textBoxPlaceName.Clear();
            }
        }
        private void textBoxPlaceName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaceName.Text))
            {
                textBoxPlaceName.Text = "Enter place name";
            }
        }

        // Field place address usefull design
        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Enter place address")
            {
                textBoxAddress.Clear();
            }
        }
        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                textBoxAddress.Text = "Enter place address";
            }
        }

        // Field place description usefull design
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Enter place description")
            {
                richTextBox1.Clear();
            }
        }
        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "Enter place description";
            }
        }
    }
}
