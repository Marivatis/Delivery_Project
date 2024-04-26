using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.Forms.CustomBorderCode
{
    public partial class CustomBorderForm : Form
    {
        private int borderSize = 1;
        private int topMenuPanelSize = 25;
        private int panelSeparatorSize = 1;
        private Color borderColor = Color.FromArgb(113, 96, 232);
        private Color topMenuPanelColor = Color.FromArgb(31, 31, 31);
        private Color panelSeparatorColor = Color.FromArgb(61, 61, 61);

        protected event EventHandler BorderSizeChanged;
        protected event EventHandler TopMenuPanelSizeChanged;
        protected event EventHandler PanelSeparatorSizeChanged;
        protected event EventHandler BorderColorChanged;
        protected event EventHandler TopMenuPanelColorChanged;
        protected event EventHandler PanelSeparatorColorChanged;

        public static event EventHandler FormClosed;

        protected CustomBorderForm()
        {
            InitializeComponent();
        }

        [Category("Custom Form Border")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                BorderSizeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        [Category("Custom Form Border")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                BorderColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        [Category("Custom Form Border")]
        public int TopMenuPanelSize
        {
            get
            {
                return topMenuPanelSize;
            }
            set
            {
                topMenuPanelSize = value;
                TopMenuPanelSizeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        [Category("Custom Form Border")]
        public Color TopMenuPanelColor
        {
            get
            {
                return topMenuPanelColor;
            }
            set
            {
                topMenuPanelColor = value;
                TopMenuPanelColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        [Category("Custom Form Border")]
        public int TopMenuBorderSize
        {
            get
            {
                return panelSeparatorSize;
            }
            set
            {
                panelSeparatorSize = value;
                PanelSeparatorSizeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        [Category("Custom Form Border")]
        public Color TopMenuBorderColor
        {
            get => panelSeparatorColor;
            set
            {
                panelSeparatorColor = value;
                PanelSeparatorColorChanged.Invoke(this, EventArgs.Empty);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void CustomBorderForm_SizeChanged(object sender, EventArgs e)
        {
            panelTopMenu.Width = Width - BorderSize * 2;
            panelSeparator.Width = Width - BorderSize * 2;
            panelBorderTop.Width = Width;
            panelBorderBottom.Width = Width;
            panelBorderLeft.Height = Height;
            panelBorderRight.Height = Height;
            buttonClose.Location = new Point(panelTopMenu.Width - TopMenuPanelSize, 0);
        }
        private void CustomBorderForm_BorderSizeChanged(object sender, EventArgs e)
        {
            panelBorderTop.Height = BorderSize;
            panelBorderBottom.Height = BorderSize;
            panelBorderLeft.Width = BorderSize;
            panelBorderRight.Width = BorderSize;

            panelTopMenu.Width = Width - BorderSize * 2;
            buttonClose.Location = new Point(panelTopMenu.Width - TopMenuPanelSize, 0);
        }
        private void CustomBorderForm_TopMenuPanelSizeChanged(object sender, EventArgs e)
        {
            panelTopMenu.Height = TopMenuPanelSize;
            buttonClose.Size = new Size(TopMenuPanelSize, TopMenuPanelSize);
            buttonClose.Location = new Point(panelTopMenu.Width - TopMenuPanelSize, 0);
        }
        private void CustomBorderForm_PanelSeparatorSizeChanged(object sender, EventArgs e)
        {
            panelSeparator.Height = TopMenuBorderSize;
        }

        private void CustomBorderForm_BorderColorChanged(object sender, EventArgs e)
        {
            panelBorderBottom.BackColor = BorderColor;
            panelBorderTop.BackColor = BorderColor;
            panelBorderLeft.BackColor = BorderColor;
            panelBorderRight.BackColor = BorderColor;
        }
        private void CustomBorderForm_TopMenuPanelColorChanged(object sender, EventArgs e)
        {
            panelTopMenu.BackColor = TopMenuPanelColor;
            buttonClose.BackColor = TopMenuPanelColor;
        }
        private void CustomBorderForm_PanelSeparatorColorChanged(object sender, EventArgs e)
        {
            panelSeparator.BackColor = TopMenuBorderColor;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}