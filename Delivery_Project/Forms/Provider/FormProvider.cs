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
using Delivery_Project.DataControl.Workplaces;
using Delivery_Project.DataControl.Workplaces.Management;
using Delivery_Project.Forms.Templates;

namespace Delivery_Project.Forms.Provider
{
    public partial class FormProvider : CustomBorderForm
    {
        private FormProviderProfile formProfile;
        private FormPlaceEditor formPlaceEditor;

        private DeliveryProvider provider;
        private DeliveryPlace place;
        private Product? selectedProduct;

        public static GetPlaceHandler? GetDeliveryPlace;

        public FormProvider(ref DeliveryProvider provider) : base()
        {
            InitializeComponent();

            this.provider = provider;

            DeliveryPlace? place = null;

            GetDeliveryPlace?.Invoke(provider.PlaceCode, out place);

            if (place is null)
            {
                MessageBox.Show("Delivery place hasn`t been loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            this.place = place;
            DeliveryPlace.PlaceChanged += Load_DataGridView;
        }

        // Transition to profile and edit place forms
        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormProviderProfile(Location, ref provider);
            formProfile.FormClosed += Enable;

            Enabled = false;
            formProfile.Show();
        }
        private void buttonEditPlace_Click(object sender, EventArgs e)
        {
            formPlaceEditor = new FormPlaceEditor(ref place);
            formPlaceEditor.FormClosed += Enable;

            Enabled = false;
            formPlaceEditor.Show();
        }
        private void Enable(object? sender, FormClosedEventArgs e)
        {
            labelPlaceName.Text = place.Name;
            labelPlaceAddress.Text = place.Address;
            labelPlaceDescription.Text = place.Description;

            Enabled = true;
        }

        // On load form functions
        private void FormProvider_Load(object sender, EventArgs e)
        {
            labelPlaceName.Text = place.Name;
            labelPlaceDeliveryPrice.Text = $"Delivery price: {place.DeliveryPrice} UAH";
            labelPlaceAddress.Text = place.Address;
            labelPlaceDescription.Text = place.Description;

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = place.Menu.List;

            dataGridView1.Columns["Name"].HeaderText = "Product";
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Price"].Width = 100;
            dataGridView1.Columns["Description"].Width = 407;
        }

        // New product add function
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            try
            {
                place.Menu.Add(product);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Product properties change apply function
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Product? product = place.Menu.FirstOrDefault(p => p.Name == selectedProduct?.Name);

            if (product is null)
            {
                MessageBox.Show($"Any product with name {selectedProduct?.Name} in menu.");
                return;
            }

            if (textBoxProductName.Text == "Enter product name")
            {
                MessageBox.Show("Enter product name first.");
                return;
            }
            if (textBoxProductPrice.Text == "Enter product price")
            {
                MessageBox.Show("Enter product price first.");
                return;
            }
            if (textBoxProductDescription.Text == "Enter product description")
            {
                MessageBox.Show("Enter product description first.");
                return;
            }

            try
            {
                product.Name = textBoxProductName.Text;
                product.Price = Convert.ToInt32(textBoxProductPrice.Text);
                product.Description = textBoxProductDescription.Text;
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Product remove function
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Product? product = place.Menu.FirstOrDefault(p => p.Name == selectedProduct?.Name);

            if (product is null)
            {
                MessageBox.Show($"Any product with name {selectedProduct?.Name} in menu.");
                return;
            }

            bool isRemoved = place.Menu.Remove(product);

            if (!isRemoved)
            {
                MessageBox.Show("Removing went wrong.");
                return;
            }
        }

        // DataGridView product select function
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return;

            selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

            if (selectedProduct is null)
                return;

            textBoxProductName.Text = selectedProduct.Name;
            textBoxProductPrice.Text = selectedProduct.Price.ToString();
            textBoxProductDescription.Text = selectedProduct.Description;
        }

        // Field product name usefull design
        private void textBoxProductName_Enter(object sender, EventArgs e)
        {
            if (textBoxProductName.Text == "Enter product name")
            {
                textBoxProductName.Clear();
            }
        }
        private void textBoxProductName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text))
            {
                textBoxProductName.Text = "Enter product name";
            }
        }

        // Field product price usefull design
        private void textBoxProductPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxProductPrice.Text == "Enter product price")
            {
                textBoxProductPrice.Clear();
            }
        }
        private void textBoxProductPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductPrice.Text))
            {
                textBoxProductPrice.Text = "Enter product price";
            }
        }
        private void textBoxProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Price field must contain only numbers");
                e.Handled = true;
            }
        }

        // Field product description usefull design
        private void textBoxProductDescription_Enter(object sender, EventArgs e)
        {
            if (textBoxProductDescription.Text == "Enter product description")
            {
                textBoxProductDescription.Clear();
            }
        }
        private void textBoxProductDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductDescription.Text))
            {
                textBoxProductDescription.Text = "Enter product description";
            }
        }

    }
}
