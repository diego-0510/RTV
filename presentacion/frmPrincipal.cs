using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{

    public partial class frmPrincipal : Form
    {
        public static listaCarros carro = new listaCarros();
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void limpiarCampos()
        {
            txtPLaca.Clear();
            txtMarca.Clear();
            txtAnioFabricacion.Clear();
            txtDueno.Clear();
            txtCcMotor.Clear();
            txtVin.Clear();
            txtCombustion.Clear();
            txtColor.Clear();

        }


        private void ingresarInformacion()
        {
            try
            {
                int placa = int.Parse(txtPLaca.Text);
                string marca = txtMarca.Text;
                string anoFabricacion = txtAnioFabricacion.Text;
                string nombreDueno = txtDueno.Text;
                int ccMotor = int.Parse(txtCcMotor.Text);
                int vin = int.Parse(txtVin.Text);
                string tipoAlimentacion = txtCombustion.Text;
                string colorExterno = txtColor.Text;
                carro.crearCarro(placa,marca,anoFabricacion,nombreDueno,ccMotor,vin,tipoAlimentacion,colorExterno);
                limpiarCampos();
                MessageBox.Show("Información Ingresada Correctamente", "Ingresada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception e)
            {
                MessageBox.Show("Información Incorrecta...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.Visible = true;
            ventanaBuscar.buscar(carro);
        }

       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresarInformacion();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            carro.leerXML();
        }

        private void lblInforamcion_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            carro.guardarXML();
        }
    }
}
