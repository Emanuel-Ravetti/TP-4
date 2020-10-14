using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_4
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            rbSimple.Checked = false;
            rbDoble.Checked = false;
            rbTriple.Checked = false;
            cbLechuga.Checked = false;
            cbTomate.Checked = false;
            cbBacon.Checked = false;
            cbSalsa.Checked = false;
            cbPepino.Checked = false;
            rbCoca.Checked = false;
            rbFanta.Checked = false;
            rbSprite.Checked = false;
            rbAgua.Checked = false;
            lblRenglones.Text = "";
            txtTotal.Text = "";

        }
    }
}
