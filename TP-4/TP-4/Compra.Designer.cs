namespace TP_4
{
    partial class Compra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNuevo = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.paEncabezado = new System.Windows.Forms.Panel();
            this.paPedido = new System.Windows.Forms.Panel();
            this.paRenglones = new System.Windows.Forms.Panel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPepino = new System.Windows.Forms.CheckBox();
            this.cbLechuga = new System.Windows.Forms.CheckBox();
            this.cbTomate = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbSalsa = new System.Windows.Forms.CheckBox();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbDoble = new System.Windows.Forms.RadioButton();
            this.rbTriple = new System.Windows.Forms.RadioButton();
            this.rbCoca = new System.Windows.Forms.RadioButton();
            this.rbFanta = new System.Windows.Forms.RadioButton();
            this.rbSprite = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.paEncabezado.SuspendLayout();
            this.paPedido.SuspendLayout();
            this.paRenglones.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(12, 12);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(514, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(514, 41);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // paEncabezado
            // 
            this.paEncabezado.Controls.Add(this.label16);
            this.paEncabezado.Controls.Add(this.label15);
            this.paEncabezado.Location = new System.Drawing.Point(6, 6);
            this.paEncabezado.Name = "paEncabezado";
            this.paEncabezado.Size = new System.Drawing.Size(616, 64);
            this.paEncabezado.TabIndex = 3;
            // 
            // paPedido
            // 
            this.paPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paPedido.Controls.Add(this.label17);
            this.paPedido.Controls.Add(this.label4);
            this.paPedido.Controls.Add(this.cbSalsa);
            this.paPedido.Controls.Add(this.cbLechuga);
            this.paPedido.Controls.Add(this.cbTomate);
            this.paPedido.Controls.Add(this.cbBacon);
            this.paPedido.Controls.Add(this.cbPepino);
            this.paPedido.Controls.Add(this.label12);
            this.paPedido.Controls.Add(this.label11);
            this.paPedido.Controls.Add(this.label10);
            this.paPedido.Controls.Add(this.label9);
            this.paPedido.Controls.Add(this.btAceptar);
            this.paPedido.Controls.Add(this.panel4);
            this.paPedido.Controls.Add(this.panel5);
            this.paPedido.Location = new System.Drawing.Point(6, 90);
            this.paPedido.Name = "paPedido";
            this.paPedido.Size = new System.Drawing.Size(616, 163);
            this.paPedido.TabIndex = 4;
            // 
            // paRenglones
            // 
            this.paRenglones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paRenglones.Controls.Add(this.btReiniciar);
            this.paRenglones.Controls.Add(this.txtTotal);
            this.paRenglones.Controls.Add(this.label14);
            this.paRenglones.Controls.Add(this.lblRenglones);
            this.paRenglones.Location = new System.Drawing.Point(6, 270);
            this.paRenglones.Name = "paRenglones";
            this.paRenglones.Size = new System.Drawing.Size(616, 183);
            this.paRenglones.TabIndex = 5;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(532, 115);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "$160";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "$190";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "$60";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "$60";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "$60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(467, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "$50";
            // 
            // cbPepino
            // 
            this.cbPepino.AutoSize = true;
            this.cbPepino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPepino.Location = new System.Drawing.Point(227, 121);
            this.cbPepino.Name = "cbPepino";
            this.cbPepino.Size = new System.Drawing.Size(70, 17);
            this.cbPepino.TabIndex = 15;
            this.cbPepino.Text = "Pepinillos";
            this.cbPepino.UseVisualStyleBackColor = true;
            // 
            // cbLechuga
            // 
            this.cbLechuga.AutoSize = true;
            this.cbLechuga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLechuga.Location = new System.Drawing.Point(227, 29);
            this.cbLechuga.Name = "cbLechuga";
            this.cbLechuga.Size = new System.Drawing.Size(68, 17);
            this.cbLechuga.TabIndex = 20;
            this.cbLechuga.Text = "Lechuga";
            this.cbLechuga.UseVisualStyleBackColor = true;
            // 
            // cbTomate
            // 
            this.cbTomate.AutoSize = true;
            this.cbTomate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTomate.Location = new System.Drawing.Point(227, 52);
            this.cbTomate.Name = "cbTomate";
            this.cbTomate.Size = new System.Drawing.Size(62, 17);
            this.cbTomate.TabIndex = 19;
            this.cbTomate.Text = "Tomate";
            this.cbTomate.UseVisualStyleBackColor = true;
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBacon.Location = new System.Drawing.Point(227, 75);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(57, 17);
            this.cbBacon.TabIndex = 18;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            // 
            // cbSalsa
            // 
            this.cbSalsa.AutoSize = true;
            this.cbSalsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSalsa.Location = new System.Drawing.Point(227, 98);
            this.cbSalsa.Name = "cbSalsa";
            this.cbSalsa.Size = new System.Drawing.Size(52, 17);
            this.cbSalsa.TabIndex = 17;
            this.cbSalsa.Text = "Salsa";
            this.cbSalsa.UseVisualStyleBackColor = true;
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.Location = new System.Drawing.Point(26, 17);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(0, 13);
            this.lblRenglones.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(458, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "TOTAL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(446, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cliente N°";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(463, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bebida";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(65, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Burger";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbTriple);
            this.panel4.Controls.Add(this.rbDoble);
            this.panel4.Controls.Add(this.rbSimple);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(5, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 100);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbAgua);
            this.panel5.Controls.Add(this.rbSprite);
            this.panel5.Controls.Add(this.rbFanta);
            this.panel5.Controls.Add(this.rbCoca);
            this.panel5.Location = new System.Drawing.Point(365, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 103);
            this.panel5.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "$220";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(24, 12);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(56, 17);
            this.rbSimple.TabIndex = 4;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbDoble
            // 
            this.rbDoble.AutoSize = true;
            this.rbDoble.Location = new System.Drawing.Point(24, 39);
            this.rbDoble.Name = "rbDoble";
            this.rbDoble.Size = new System.Drawing.Size(53, 17);
            this.rbDoble.TabIndex = 5;
            this.rbDoble.TabStop = true;
            this.rbDoble.Text = "Doble";
            this.rbDoble.UseVisualStyleBackColor = true;
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.Location = new System.Drawing.Point(24, 67);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(51, 17);
            this.rbTriple.TabIndex = 6;
            this.rbTriple.TabStop = true;
            this.rbTriple.Text = "Triple";
            this.rbTriple.UseVisualStyleBackColor = true;
            // 
            // rbCoca
            // 
            this.rbCoca.AutoSize = true;
            this.rbCoca.Location = new System.Drawing.Point(11, 11);
            this.rbCoca.Name = "rbCoca";
            this.rbCoca.Size = new System.Drawing.Size(74, 17);
            this.rbCoca.TabIndex = 7;
            this.rbCoca.TabStop = true;
            this.rbCoca.Text = "Coca-Cola";
            this.rbCoca.UseVisualStyleBackColor = true;
            // 
            // rbFanta
            // 
            this.rbFanta.AutoSize = true;
            this.rbFanta.Location = new System.Drawing.Point(11, 34);
            this.rbFanta.Name = "rbFanta";
            this.rbFanta.Size = new System.Drawing.Size(52, 17);
            this.rbFanta.TabIndex = 8;
            this.rbFanta.TabStop = true;
            this.rbFanta.Text = "Fanta";
            this.rbFanta.UseVisualStyleBackColor = true;
            // 
            // rbSprite
            // 
            this.rbSprite.AutoSize = true;
            this.rbSprite.Location = new System.Drawing.Point(11, 56);
            this.rbSprite.Name = "rbSprite";
            this.rbSprite.Size = new System.Drawing.Size(52, 17);
            this.rbSprite.TabIndex = 9;
            this.rbSprite.TabStop = true;
            this.rbSprite.Text = "Sprite";
            this.rbSprite.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(11, 79);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 10;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(505, 142);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(532, 12);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btReiniciar.TabIndex = 7;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 474);
            this.Controls.Add(this.paRenglones);
            this.Controls.Add(this.paPedido);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.paEncabezado);
            this.Name = "Compra";
            this.Text = "Form1";
            this.paEncabezado.ResumeLayout(false);
            this.paEncabezado.PerformLayout();
            this.paPedido.ResumeLayout(false);
            this.paPedido.PerformLayout();
            this.paRenglones.ResumeLayout(false);
            this.paRenglones.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Panel paEncabezado;
        private System.Windows.Forms.Panel paPedido;
        private System.Windows.Forms.CheckBox cbSalsa;
        private System.Windows.Forms.CheckBox cbLechuga;
        private System.Windows.Forms.CheckBox cbTomate;
        private System.Windows.Forms.CheckBox cbBacon;
        private System.Windows.Forms.CheckBox cbPepino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Panel paRenglones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbTriple;
        private System.Windows.Forms.RadioButton rbDoble;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.RadioButton rbSprite;
        private System.Windows.Forms.RadioButton rbFanta;
        private System.Windows.Forms.RadioButton rbCoca;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btReiniciar;
    }
}

