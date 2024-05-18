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
    public partial class FormPlaceEditor : TemplateCustomBorderForm
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
            textBoxPlaceDeliveryPercent.Text = place.DeliveryPercent.ToString();
            textBoxPlaceDeliveryPrice.Text = place.DeliveryPrice.ToString();
            textBoxPlaceAddress.Text = place.Address;
            richTextBoxPlaceDescription.Text = place.Description;

            CenterToScreen();
        }

        // Saves data from text boxes to corresponding place
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (place.Name != textBoxPlaceName.Text)
                    place.Name = textBoxPlaceName.Text;

                if (place.DeliveryPercent != Convert.ToInt32(textBoxPlaceDeliveryPercent.Text))
                    place.DeliveryPercent = Convert.ToInt32(textBoxPlaceDeliveryPercent.Text);

                if (place.DeliveryPrice != Convert.ToInt32(textBoxPlaceDeliveryPrice.Text))
                    place.DeliveryPrice = Convert.ToInt32(textBoxPlaceDeliveryPrice.Text);

                if (place.Address != textBoxPlaceAddress.Text)
                    place.Address = textBoxPlaceAddress.Text;

                if (place.Description != richTextBoxPlaceDescription.Text)
                    place.Description = richTextBoxPlaceDescription.Text;

                Close();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Field place name usefull design
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

        // Field place delivery price usefull design
        private void textBoxPlaceDeliveryPercent_Enter(object sender, EventArgs e)
        {
            if (textBoxPlaceDeliveryPercent.Text == "Enter place delivery percent")
            {
                textBoxPlaceDeliveryPercent.Clear();
            }
        }
        private void textBoxPlaceDeliveryPercent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaceDeliveryPercent.Text))
            {
                textBoxPlaceDeliveryPercent.Text = "Enter place delivery percent";
            }
        }
        private void textBoxPlaceDeliveryPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Delivery percent field must contain only numbers");
                e.Handled = true;
            }
        }

        // Field place delivery price usefull design
        private void textBoxPlaceDeliveryPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPlaceDeliveryPrice.Text == "Enter place delivery price")
            {
                textBoxPlaceDeliveryPrice.Clear();
            }
        }
        private void textBoxPlaceDeliveryPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaceDeliveryPrice.Text))
            {
                textBoxPlaceDeliveryPrice.Text = "Enter place delivery price";
            }
        }
        private void textBoxPlaceDeliveryPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Delivery price field must contain only numbers");
                e.Handled = true;
            }
        }

        // Field place address usefull design
        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxPlaceAddress.Text == "Enter place address")
            {
                textBoxPlaceAddress.Clear();
            }
        }
        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaceAddress.Text))
            {
                textBoxPlaceAddress.Text = "Enter place address";
            }
        }

        // Field place description usefull design
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBoxPlaceDescription.Text == "Enter place description")
            {
                richTextBoxPlaceDescription.Clear();
            }
        }
        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxPlaceDescription.Text))
            {
                richTextBoxPlaceDescription.Text = "Enter place description";
            }
        }


    }
}
