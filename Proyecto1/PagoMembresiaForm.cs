using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Proyecto1;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class PagoMembresiaForm : Form
    {
        public PagoMembresiaForm()
        {
            InitializeComponent();
        }

        private void btnVolveraMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
