﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongHienCoop
{
    public partial class create_delivery : Form
    {
        public create_delivery()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backtoproduct(object sender, EventArgs e)
        {
            this.Close();
            Products p = new Products();
            p.StartPosition = FormStartPosition.Manual;
            p.Left = 250;
            p.Top = 250;
            p.ShowDialog();
        }
    }
}
