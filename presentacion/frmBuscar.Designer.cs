
namespace presentacion
{
    partial class frmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlacaBuscar = new System.Windows.Forms.Label();
            this.txtPLacaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCombustion = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtCcMotor = new System.Windows.Forms.TextBox();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.txtAnioFabricacion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblMotot = new System.Windows.Forms.Label();
            this.lblNombreDueno = new System.Windows.Forms.Label();
            this.lblAnoFabricacion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlacaBuscar
            // 
            this.lblPlacaBuscar.AutoSize = true;
            this.lblPlacaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaBuscar.Location = new System.Drawing.Point(12, 67);
            this.lblPlacaBuscar.Name = "lblPlacaBuscar";
            this.lblPlacaBuscar.Size = new System.Drawing.Size(101, 16);
            this.lblPlacaBuscar.TabIndex = 1;
            this.lblPlacaBuscar.Text = "Placa a buscar:";
            // 
            // txtPLacaBuscar
            // 
            this.txtPLacaBuscar.Location = new System.Drawing.Point(119, 66);
            this.txtPLacaBuscar.Name = "txtPLacaBuscar";
            this.txtPLacaBuscar.Size = new System.Drawing.Size(134, 20);
            this.txtPLacaBuscar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar Vehiculo mediante la placa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(58, 449);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 34);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(117, 380);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(134, 20);
            this.txtColor.TabIndex = 30;
            // 
            // txtCombustion
            // 
            this.txtCombustion.Enabled = false;
            this.txtCombustion.Location = new System.Drawing.Point(117, 335);
            this.txtCombustion.Name = "txtCombustion";
            this.txtCombustion.Size = new System.Drawing.Size(134, 20);
            this.txtCombustion.TabIndex = 29;
            // 
            // txtVin
            // 
            this.txtVin.Enabled = false;
            this.txtVin.Location = new System.Drawing.Point(117, 285);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(134, 20);
            this.txtVin.TabIndex = 28;
            // 
            // txtCcMotor
            // 
            this.txtCcMotor.Enabled = false;
            this.txtCcMotor.Location = new System.Drawing.Point(117, 244);
            this.txtCcMotor.Name = "txtCcMotor";
            this.txtCcMotor.Size = new System.Drawing.Size(134, 20);
            this.txtCcMotor.TabIndex = 27;
            // 
            // txtDueno
            // 
            this.txtDueno.Enabled = false;
            this.txtDueno.Location = new System.Drawing.Point(117, 191);
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(134, 20);
            this.txtDueno.TabIndex = 26;
            // 
            // txtAnioFabricacion
            // 
            this.txtAnioFabricacion.Enabled = false;
            this.txtAnioFabricacion.Location = new System.Drawing.Point(117, 146);
            this.txtAnioFabricacion.Name = "txtAnioFabricacion";
            this.txtAnioFabricacion.Size = new System.Drawing.Size(134, 20);
            this.txtAnioFabricacion.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(58, 104);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 380);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(43, 16);
            this.lblColor.TabIndex = 23;
            this.lblColor.Text = "Color:";
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.Location = new System.Drawing.Point(12, 335);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(82, 16);
            this.lblAlimentacion.TabIndex = 22;
            this.lblAlimentacion.Text = "Combustion:";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.Location = new System.Drawing.Point(12, 285);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(30, 16);
            this.lblVin.TabIndex = 21;
            this.lblVin.Text = "Vin:";
            this.lblVin.UseWaitCursor = true;
            // 
            // lblMotot
            // 
            this.lblMotot.AutoSize = true;
            this.lblMotot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotot.Location = new System.Drawing.Point(12, 244);
            this.lblMotot.Name = "lblMotot";
            this.lblMotot.Size = new System.Drawing.Size(66, 16);
            this.lblMotot.TabIndex = 20;
            this.lblMotot.Text = "Motor CC:";
            // 
            // lblNombreDueno
            // 
            this.lblNombreDueno.AutoSize = true;
            this.lblNombreDueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDueno.Location = new System.Drawing.Point(12, 191);
            this.lblNombreDueno.Name = "lblNombreDueno";
            this.lblNombreDueno.Size = new System.Drawing.Size(103, 16);
            this.lblNombreDueno.TabIndex = 19;
            this.lblNombreDueno.Text = "Nombre Dueño:";
            // 
            // lblAnoFabricacion
            // 
            this.lblAnoFabricacion.AutoSize = true;
            this.lblAnoFabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoFabricacion.Location = new System.Drawing.Point(12, 146);
            this.lblAnoFabricacion.Name = "lblAnoFabricacion";
            this.lblAnoFabricacion.Size = new System.Drawing.Size(109, 16);
            this.lblAnoFabricacion.TabIndex = 18;
            this.lblAnoFabricacion.Text = "Año Fabricacion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 104);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 16);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(221, 449);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 34);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 527);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCombustion);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.txtCcMotor);
            this.Controls.Add(this.txtDueno);
            this.Controls.Add(this.txtAnioFabricacion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAlimentacion);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.lblMotot);
            this.Controls.Add(this.lblNombreDueno);
            this.Controls.Add(this.lblAnoFabricacion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPLacaBuscar);
            this.Controls.Add(this.lblPlacaBuscar);
            this.Name = "frmBuscar";
            this.Text = "Buscar Vehiculo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlacaBuscar;
        private System.Windows.Forms.TextBox txtPLacaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCombustion;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtCcMotor;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.TextBox txtAnioFabricacion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblMotot;
        private System.Windows.Forms.Label lblNombreDueno;
        private System.Windows.Forms.Label lblAnoFabricacion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnEditar;
    }
}