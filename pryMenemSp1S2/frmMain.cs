using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenemSp1S2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            ClsRepuestos ObjRepuesto = new ClsRepuestos();

            ObjRepuesto.codigo = Convert.ToInt32(txtCodigo.Text);
            ObjRepuesto.nombre = txtNombre.Text;
            ObjRepuesto.marca = cboMarca.Text;
            ObjRepuesto.precio = Convert.ToInt32(txtPrecio.Text);

            if (rbImportado.Checked)
            {
                ObjRepuesto.origen = "Importado";
            }
            else
            {
                ObjRepuesto.origen = "Nacional";
            }

            MessageBox.Show("Repuesto Registrado");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
