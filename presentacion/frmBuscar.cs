using negocio;
using datos;
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
    public partial class frmBuscar : Form
    {
        public int placaBuscar = 0;
        public listaCarros lista=frmPrincipal.carro;
        public objCarro carroBuscado;
        public frmBuscar()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                mostrarTxt();
                placaBuscar = int.Parse(txtPLacaBuscar.Text);
                buscar(lista);
                
                
            }
            catch(Exception)
            {
               MessageBox.Show("Información Incorrecta...", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void buscar(listaCarros lista)
        {
            carroBuscado=lista.buscarCarro(placaBuscar);
            txtMarca.Text = carroBuscado.marca;
            txtAnioFabricacion.Text = carroBuscado.anoFabricacion;
            txtDueno.Text = carroBuscado.nombreDueno;
            txtCcMotor.Text = Convert.ToString(carroBuscado.ccMotor);
            txtVin.Text= Convert.ToString(carroBuscado.vin);
            txtCombustion.Text = carroBuscado.tipoAlimentacion;
            txtColor.Text = carroBuscado.colorExterno;
            btnEditar.Enabled = true;
            
        }

        private void modificar() {
            try
            {
                carroBuscado.marca = txtMarca.Text;
                carroBuscado.anoFabricacion = txtAnioFabricacion.Text;
                carroBuscado.nombreDueno = txtDueno.Text;
                carroBuscado.ccMotor = int.Parse(txtCcMotor.Text);
                carroBuscado.vin = int.Parse(txtVin.Text);
                carroBuscado.tipoAlimentacion = txtCombustion.Text;
                carroBuscado.colorExterno = txtColor.Text;
                MessageBox.Show("Información Modificada Correctamente", "Ingresada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ocultarTxt();
                limpiarCampos();
            }
            catch(Exception e)
            {
               MessageBox.Show("Información Incorrecta...", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void limpiarCampos()
        {
            txtPLacaBuscar.Clear();
            txtMarca.Clear();
            txtAnioFabricacion.Clear();
            txtDueno.Clear();
            txtCcMotor.Clear();
            txtVin.Clear();
            txtCombustion.Clear();
            txtColor.Clear();

        }

        private void mostrarTxt()
        {
            txtMarca.Enabled = true;
            txtAnioFabricacion.Enabled = true;
            txtDueno.Enabled = true;
            txtCcMotor.Enabled = true;
            txtVin.Enabled = true;
            txtCombustion.Enabled = true;
            txtColor.Enabled = true;
        }

        private void ocultarTxt()
        {
            txtMarca.Enabled = false;
            txtAnioFabricacion.Enabled = false;
            txtDueno.Enabled = false;
            txtCcMotor.Enabled = false;
            txtVin.Enabled = false;
            txtCombustion.Enabled = false;
            txtColor.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
