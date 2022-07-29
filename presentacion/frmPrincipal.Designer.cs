namespace presentacion
{
    partial class frmPrincipal
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblAnoFabricacion = new System.Windows.Forms.Label();
            this.lblNombreDueno = new System.Windows.Forms.Label();
            this.lblMotot = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtPLaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtAnioFabricacion = new System.Windows.Forms.TextBox();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.txtCcMotor = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtCombustion = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblInforamcion = new System.Windows.Forms.Label();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(21, 85);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(46, 16);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 122);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 16);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblAnoFabricacion
            // 
            this.lblAnoFabricacion.AutoSize = true;
            this.lblAnoFabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoFabricacion.Location = new System.Drawing.Point(21, 164);
            this.lblAnoFabricacion.Name = "lblAnoFabricacion";
            this.lblAnoFabricacion.Size = new System.Drawing.Size(109, 16);
            this.lblAnoFabricacion.TabIndex = 2;
            this.lblAnoFabricacion.Text = "Año Fabricacion:";
            // 
            // lblNombreDueno
            // 
            this.lblNombreDueno.AutoSize = true;
            this.lblNombreDueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDueno.Location = new System.Drawing.Point(21, 209);
            this.lblNombreDueno.Name = "lblNombreDueno";
            this.lblNombreDueno.Size = new System.Drawing.Size(103, 16);
            this.lblNombreDueno.TabIndex = 3;
            this.lblNombreDueno.Text = "Nombre Dueño:";
            // 
            // lblMotot
            // 
            this.lblMotot.AutoSize = true;
            this.lblMotot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotot.Location = new System.Drawing.Point(21, 262);
            this.lblMotot.Name = "lblMotot";
            this.lblMotot.Size = new System.Drawing.Size(66, 16);
            this.lblMotot.TabIndex = 4;
            this.lblMotot.Text = "Motor CC:";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.Location = new System.Drawing.Point(21, 303);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(30, 16);
            this.lblVin.TabIndex = 5;
            this.lblVin.Text = "Vin:";
            this.lblVin.UseWaitCursor = true;
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.Location = new System.Drawing.Point(21, 353);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(82, 16);
            this.lblAlimentacion.TabIndex = 6;
            this.lblAlimentacion.Text = "Combustion:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(21, 398);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(43, 16);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color:";
            // 
            // txtPLaca
            // 
            this.txtPLaca.Location = new System.Drawing.Point(67, 85);
            this.txtPLaca.Name = "txtPLaca";
            this.txtPLaca.Size = new System.Drawing.Size(134, 22);
            this.txtPLaca.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(67, 122);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 22);
            this.txtMarca.TabIndex = 9;
            // 
            // txtAnioFabricacion
            // 
            this.txtAnioFabricacion.Location = new System.Drawing.Point(126, 164);
            this.txtAnioFabricacion.Name = "txtAnioFabricacion";
            this.txtAnioFabricacion.Size = new System.Drawing.Size(134, 22);
            this.txtAnioFabricacion.TabIndex = 10;
            // 
            // txtDueno
            // 
            this.txtDueno.Location = new System.Drawing.Point(126, 209);
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(134, 22);
            this.txtDueno.TabIndex = 11;
            // 
            // txtCcMotor
            // 
            this.txtCcMotor.Location = new System.Drawing.Point(126, 262);
            this.txtCcMotor.Name = "txtCcMotor";
            this.txtCcMotor.Size = new System.Drawing.Size(134, 22);
            this.txtCcMotor.TabIndex = 12;
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(126, 303);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(134, 22);
            this.txtVin.TabIndex = 13;
            // 
            // txtCombustion
            // 
            this.txtCombustion.Location = new System.Drawing.Point(126, 353);
            this.txtCombustion.Name = "txtCombustion";
            this.txtCombustion.Size = new System.Drawing.Size(134, 22);
            this.txtCombustion.TabIndex = 14;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(126, 398);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(134, 22);
            this.txtColor.TabIndex = 15;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Location = new System.Drawing.Point(126, 467);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 34);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblInforamcion
            // 
            this.lblInforamcion.AutoSize = true;
            this.lblInforamcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblInforamcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforamcion.Location = new System.Drawing.Point(52, 47);
            this.lblInforamcion.Name = "lblInforamcion";
            this.lblInforamcion.Size = new System.Drawing.Size(208, 18);
            this.lblInforamcion.TabIndex = 17;
            this.lblInforamcion.Text = "Ingresar información del Carro";
            this.lblInforamcion.Click += new System.EventHandler(this.lblInforamcion_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1});
            this.buscarToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.buscarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.buscarToolStripMenuItem.Text = "Opciones";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar y Editar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseLeave += new System.EventHandler(this.MenuStrip1_MouseLeave);
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(318, 526);
            this.Controls.Add(this.lblInforamcion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCombustion);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.txtCcMotor);
            this.Controls.Add(this.txtDueno);
            this.Controls.Add(this.txtAnioFabricacion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPLaca);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAlimentacion);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.lblMotot);
            this.Controls.Add(this.lblNombreDueno);
            this.Controls.Add(this.lblAnoFabricacion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Ingresar Vehiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblAnoFabricacion;
        private System.Windows.Forms.Label lblNombreDueno;
        private System.Windows.Forms.Label lblMotot;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtPLaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtAnioFabricacion;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.TextBox txtCcMotor;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtCombustion;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblInforamcion;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
    }
}

