﻿using System;
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
    public partial class FormCourierRegisteration : CustomBorderForm
    {
        public FormCourierRegisteration() : base()
        {
            InitializeComponent();
        }

        private void FormCourierRegisteration_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
