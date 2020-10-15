﻿using BA;
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
    public partial class frmCompra : Form
    {
        #region PROPIEDADES
        Pedido pedido;
        RngPedido rngPedido;
        #endregion

        #region CONSTRUCTOR
        public frmCompra()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTOS
        private void btNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevoPedido();
            txtFecha.Text = pedido.Fecha.ToString("dd/MM/yyyy");
            //show nro pedido

        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            rngPedido = new RngPedido();
            //seleccion de hamburguesa
            if (rbSimple.Checked == true)
            {
                rngPedido.Hamburguesa = 160;
            }
            else if (rbDoble.Checked == true)
            {
                rngPedido.Hamburguesa = 190;
            }
            else if (rbTriple.Checked == true)
            {
                rngPedido.Hamburguesa = 220;
            }
            
            //seleccion de toppings
            if (cbLechuga.Checked == true)
            {
                rngPedido.Lechuga = true;
            }
            else if (cbTomate.Checked == true)
            {
                rngPedido.Tomate = true;
            }
            else if (cbBacon.Checked==true)
            {
                rngPedido.Bacon = true;
            }
            else if (cbSalsa.Checked == true)
            {
                rngPedido.Salsa = true;
            }
            else if (cbPepino.Checked == true)
            {
                rngPedido.Pepinillos = true;
            }

            //seleccion de bebida
            if (rbCoca.Checked == true || rbFanta.Checked == true || rbSprite.Checked==true)
            {
                rngPedido.Bebida = 60;
            }
            else if (rbAgua.Checked == true)
            {
                rngPedido.Bebida = 60;
            }

            txtTotal.Text = rngPedido.Total().ToString();
        }
        #endregion

        #region METODOS
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

        private void NuevoPedido()
        {
            pedido = new Pedido();
        }

        private void LimpiarOpciones()
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
        }

        #endregion


    }
}
