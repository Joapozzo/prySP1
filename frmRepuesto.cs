using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClassVeterinaria
{
    public partial class frmRepuesto : Form
    {

        List<ClsRepuesto> listaRepuestos = new List<ClsRepuesto>();

        void LimpiarDatos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbMarca.SelectedIndex = -1;
            txtPrecio.Text = "";
            optNacional.Checked = true;
        }

        public frmRepuesto()
        {
            InitializeComponent();
        }

        private void frmRepuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsRepuesto objRepuesto = new ClsRepuesto();

            objRepuesto.Codigo = int.Parse(txtCodigo.Text);
            objRepuesto.Nombre = txtNombre.Text;
            objRepuesto.Marca = cmbMarca.Text;
            objRepuesto.Precio = int.Parse(txtPrecio.Text);

            if (optImportado.Checked)
            {
                objRepuesto.Origen = "Importado";
            }
            else
            {
                objRepuesto.Origen = "Nacional";
            }

            MessageBox.Show(objRepuesto.ObtenerDatos());

            listaRepuestos.Add(objRepuesto);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            foreach (ClsRepuesto repuesto in listaRepuestos)
            {
                lstLista.Items.Add("Nombre:  " + repuesto.Nombre + "   Codigo:  " + repuesto.Codigo.ToString());
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
