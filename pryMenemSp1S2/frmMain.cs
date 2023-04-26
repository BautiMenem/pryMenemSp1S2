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
        private const string PATH_ARCHIVO = "Repuestos.txt";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos()) // si los datos son correctos
            {
                // crear un nuevo repuesto
                Repuesto nuevoRep = CrearRepuesto();
                // grabar en el archivo
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = PATH_ARCHIVO;
                Repuestos.GrabarRepuesto(nuevoRep);
                // restaurar la interfaz al estado inicial
                MessageBox.Show("Registrado!");
                Inicializar();
                
}
            else // si hay algún error
            {
                MessageBox.Show("Datos incorrectos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            txtCodigo.Text = ""; // limpiar los textBox
            txtNombre.Text = "";
            txtPrecio.Text = "";
            // cargar el comboBox
            cboMarca.Items.Clear();
            cboMarca.Items.Add("Marca A");
            cboMarca.Items.Add("Marca B");
            cboMarca.Items.Add("Marca C");
            cboMarca.SelectedIndex = 0;
            // marcar la opción de origen Nacional
            rbNacional.Checked = true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
    
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if (!Char.IsNumber(e.KeyChar) &&
            e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos()

{
            // devuelve falso si no se cumplen todas las condiciones
           bool resultado = false;
            if(txtCodigo.Text != "") // controla el valor del código
            {
               if(txtNombre.Text != "") // controla el nombre
               {
                  if(txtPrecio.Text != "" ) // controla el precio
                  {
                    Archivo Repuestos = new Archivo();
                    Repuestos.NombreArchivo = PATH_ARCHIVO;
                    // controla que no se repita el codigo del repuesto
                    if (Repuestos.BuscarCodigoRepuesto(txtCodigo.Text) == false)
                    {
                      resultado = true; // devuelve verdadero sólo si todas
                      // las condiciones se cumplieron
                    }
                  }
               }
            }
            return resultado;
        }


        private Repuesto CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            Repuesto nuevoRep = new Repuesto();
            // se asignan los valores a todas sus propiedades
            nuevoRep.codigo = txtCodigo.Text;
            nuevoRep.nombre = txtNombre.Text;
            nuevoRep.marca = cboMarca.SelectedItem.ToString();
            nuevoRep.precio = decimal.Parse(txtPrecio.Text);
            if (rbNacional.Checked)
            {
                nuevoRep.origen = "Nacional";
            }
            else
            {
                nuevoRep.origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado con sus valores
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }


    }

}
