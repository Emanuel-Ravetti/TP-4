using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        Contador contador = new Contador();
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
            this.paPedido.Enabled = true;
            this.paRenglones.Enabled = true;

            LimpiarControles();
            NuevoPedido();
            txtFecha.Text = pedido.Fecha.ToString("dd/MM/yyyy");
            txtCliente.Text = contador.ContadorCliente().ToString();
            

        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            rngPedido = new RngPedido();
            //seleccion de hamburguesa
            if(rbSimple.Checked == false & rbDoble.Checked == false & rbTriple.Checked == false)
            {
                MessageBox.Show("No seleccionó hamburguesa", "Error");
            }
            else
            {
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
                if (cbTomate.Checked == true)
                {
                    rngPedido.Tomate = true;
                }
                if (cbBacon.Checked == true)
                {
                    rngPedido.Bacon = true;
                }
                if (cbSalsa.Checked == true)
                {
                    rngPedido.Salsa = true;
                }
                if (cbPepino.Checked == true)
                {
                    rngPedido.Pepinillos = true;
                }

                //seleccion de bebida
                if (rbCoca.Checked == true)
                {
                    rngPedido.Coca = true;
                    rngPedido.Bebida = 60;
                }
                else if (rbFanta.Checked == true)
                {
                    rngPedido.Fanta = true;
                    rngPedido.Bebida = 60;
                }
                else if (rbSprite.Checked == true)
                {
                    rngPedido.Sprite = true;
                    rngPedido.Bebida = 60;
                }
                else if (rbAgua.Checked == true)
                {
                    rngPedido.Agua = true;
                    rngPedido.Bebida = 40;
                }

                try
                {
                    pedido.AddRngPedido(rngPedido);
                }
                catch (Exception)
                {
                    MessageBox.Show("Alcanzó el máximo de pedidos", "Error");
                }

                txtTotal.Text = pedido.Total.ToString();

                MuestraPedidos();
                LimpiarSeleccion();
            }           

        }
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            pedido.ReiniciarPedido();
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

        private void LimpiarSeleccion()
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

        private void NuevoPedido()
        {
            pedido = new Pedido();
            
        }

        private void MuestraPedidos()
        {
            lblRenglones.Text = pedido.MuestraPedidos();
        }
        #endregion


    }
}
