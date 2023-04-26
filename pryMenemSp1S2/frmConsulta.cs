using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMenemSp1S2
{
    public partial class frmConsulta : Form
    {
        private string PATH_ARCHIVO;
        public frmConsulta(string Path)
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }
        
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {         
            cboMarca2.Items.Clear();
            cboMarca2.Items.Add("Peugeot");
            cboMarca2.Items.Add("Citroen");
            cboMarca2.Items.Add("Renault");
            cboMarca2.SelectedIndex = 0;
            rbNacional2.Checked = true;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = PATH_ARCHIVO;
            List<Repuesto> repuestos = Repuestos.ObtenerRepuestosOrdenados();
            
            dgvRepuestos.Rows.Clear();
            
            foreach (Repuesto repuesto in repuestos)
            {
                
                if (repuesto.marca == cboMarca2.SelectedItem.ToString())
                {
                    
                    if (rbImportado2.Checked && repuesto.origen == "Importado")
                    {
                        
                        dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                        repuesto.marca, repuesto.origen,
                        repuesto.precio.ToString());
                    }
                    else
                    {
                        if (rbNacional2.Checked && repuesto.origen == "Nacional")
                        {
                            
                            dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                            repuesto.marca, repuesto.origen,
                            repuesto.precio.ToString());
                        }
                        else
                        {
                            if (rbAmbos.Checked)
                            {
                                
                                dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                                repuesto.marca, repuesto.origen,
                                repuesto.precio.ToString());
                            }
                        }
                    }
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
