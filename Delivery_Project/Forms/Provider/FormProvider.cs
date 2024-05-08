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
        private FormProviderProfile? formProfile;
        private FormPlaceEditor? formPlaceEditor;

        private DeliveryProvider _provider;
        private DeliveryPlace _place;

        private Product? _selectedProduct;

        public static GetPlaceHandler? GetDeliveryPlace;

        public FormProvider(ref DeliveryProvider provider) : base()
        {
            InitializeComponent();

            _provider = provider;

            DeliveryPlace? place = null;

            GetDeliveryPlace?.Invoke(provider.PlaceCode, out place);

            if (place is null)
            {
                MessageBox.Show("Delivery place hasn`t been loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            _place = place;
            DeliveryPlace.PlaceChanged += Load_DataGridView;
        }

        // Transition to profile and edit place forms
        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            formProfile = new FormProviderProfile(Location, ref _provider);
            formProfile.ShowDialog();
        }
        private void buttonEditPlace_Click(object sender, EventArgs e)
        {
            formPlaceEditor = new FormPlaceEditor(ref _place);
            formPlaceEditor.FormClosed += FormPlaceEditor_FormClosed;
            formPlaceEditor.ShowDialog();
        }

        // On load form functions
        private void FormProvider_Load(object sender, EventArgs e)
        {
            labelPlaceName.Text = _place.Name;
            labelPlaceDeliveryPrice.Text = $"Delivery price: {_place.DeliveryPrice} UAH";
            labelPlaceAddress.Text = _place.Address;
            labelPlaceDescription.Text = _place.Description;

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _place.Menu.ToList();

            dataGridView1.ClearSelection();

            dataGridView1.Columns["Name"].HeaderText = "Product";
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Price"].Width = 100;
            dataGridView1.Columns["Description"].Width = 407;
        }

        // FormPlaceEditor closed event handler
        private void FormPlaceEditor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            labelPlaceName.Text = _place.Name;
            labelPlaceDeliveryPrice.Text = $"Delivery price: {_place.DeliveryPrice} UAH";
            labelPlaceAddress.Text = _place.Address;
            labelPlaceDescription.Text = _place.Description;
        }

        // New product add function
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            try
            {
                _place.Menu.Add(product);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBoxProductName.Text = "Enter product name";
            textBoxProductPrice.Text = "Enter product price";
            textBoxProductDescription.Text = "Enter product description";
        }

        // Product properties change apply function
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Product? product = _place.Menu.FirstOrDefault(p => p.Name == _selectedProduct?.Name);

            if (product is null)
            {
                MessageBox.Show($"Any product with name {_selectedProduct?.Name} in menu.");
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
                if (product.Name != textBoxProductName.Text) 
                    product.Name = textBoxProductName.Text;

                if (product.Price != Convert.ToInt32(textBoxProductPrice.Text))
                    product.Price = Convert.ToInt32(textBoxProductPrice.Text);

                if (product.Description != textBoxProductDescription.Text)
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
            Product? product = _place.Menu.FirstOrDefault(p => p.Name == _selectedProduct?.Name);

            if (product is null)
            {
                MessageBox.Show($"Any product with name {_selectedProduct?.Name} in menu.");
                return;
            }

            bool isRemoved = _place.Menu.Remove(product);

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

            _selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

            if (_selectedProduct is null)
                return;

            textBoxProductName.Text = _selectedProduct.Name;
            textBoxProductPrice.Text = _selectedProduct.Price.ToString();
            textBoxProductDescription.Text = _selectedProduct.Description;
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
