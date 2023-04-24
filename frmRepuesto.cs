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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                cmbMarca.Enabled = true;
            }
            else
            {
                cmbMarca.Enabled = false;
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                txtPrecio.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
                btnConsultar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
                btnConsultar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("INGRESE UNICAMENTE NUMEROS", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) 
            {
                MessageBox.Show("INGRESE UNICAMENTE LETRAS", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("INGRESE UNICAMENTE NUMEROS", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }

}
