using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Project.Forms.CustomBorderCode
{
    partial class CustomBorderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        private void InitializeComponent()
        {
            buttonClose = new Button();
            panelSeparator = new Panel();
            panelTopMenu = new Panel();
            panelBorderTop = new Panel();
            panelBorderBottom = new Panel();
            panelBorderLeft = new Panel();
            panelBorderRight = new Panel();

            //
            // buttonClose
            //
            buttonClose.BackColor = TopMenuPanelColor;
            buttonClose.ForeColor = Color.White;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.Size = new Size(TopMenuPanelSize, TopMenuPanelSize);
            buttonClose.Location = new Point(panelTopMenu.Width - TopMenuPanelSize, 0);
            buttonClose.Text = "X";
            buttonClose.Click += buttonClose_Click;
            //
            // panelSeparator
            //
            panelSeparator.Dock = DockStyle.Top;
            panelSeparator.Size = new Size(Width - BorderSize * 2, TopMenuBorderSize);
            panelSeparator.BackColor = TopMenuBorderColor;
            //
            // panelTopMenu
            //
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Size = new Size(Width - BorderSize * 2, TopMenuPanelSize);
            panelTopMenu.BackColor = TopMenuPanelColor;
            panelTopMenu.Controls.Add(buttonClose);
            panelTopMenu.MouseDown += panelTopMenu_MouseDown;
            //
            // panelBorderTop
            //
            panelBorderTop.Dock = DockStyle.Top;
            panelBorderTop.Size = new Size(Width, BorderSize);
            panelBorderTop.BackColor = BorderColor;
            //
            // panelBorderBottom
            //
            panelBorderBottom.Dock = DockStyle.Bottom;
            panelBorderBottom.Size = new Size(Width, BorderSize);
            panelBorderBottom.BackColor = BorderColor;
            //
            // panelBorderLeft
            //
            panelBorderLeft.Dock = DockStyle.Left;
            panelBorderLeft.Size = new Size(BorderSize, Height);
            panelBorderLeft.BackColor = BorderColor;
            //
            // panelBorderRight
            //
            panelBorderRight.Dock = DockStyle.Right;
            panelBorderRight.Size = new Size(BorderSize, Height);
            panelBorderRight.BackColor = BorderColor;
            //
            // CustomBorderForm
            //
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(31, 31, 31);
            SizeChanged += CustomBorderForm_SizeChanged;
            BorderSizeChanged += CustomBorderForm_BorderSizeChanged;
            TopMenuPanelSizeChanged += CustomBorderForm_TopMenuPanelSizeChanged;
            PanelSeparatorSizeChanged += CustomBorderForm_PanelSeparatorSizeChanged;
            BorderColorChanged += CustomBorderForm_BorderColorChanged;
            TopMenuPanelColorChanged += CustomBorderForm_TopMenuPanelColorChanged;
            PanelSeparatorColorChanged += CustomBorderForm_PanelSeparatorColorChanged;
            Controls.Add(panelSeparator);
            Controls.Add(panelTopMenu);
            Controls.Add(panelBorderTop);
            Controls.Add(panelBorderBottom);
            Controls.Add(panelBorderLeft);
            Controls.Add(panelBorderRight);
        }

        #endregion

        private Panel panelTopMenu;
        private Panel panelBorderTop;
        private Panel panelBorderBottom;
        private Panel panelBorderLeft;
        private Panel panelBorderRight;
        private Panel panelSeparator;
        private Button buttonClose;
    }
}