﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class CalendarioForm : Form
    {
        public CalendarioForm()
        {
            InitializeComponent();
        }

        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
