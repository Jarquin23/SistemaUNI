using SistemaUNI.Controlador;
using SistemaUNI.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUNI.Vista
{
    
    public partial class FrmRegistros : Form
    {
        FacultadControlador facultades = new FacultadControlador();
        CarreraControlador carreras = new CarreraControlador();

        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (carreras.Agregar(tbName.Text, tbCode.Text, Double.Parse(tbPrecio.Text)))
            {
                MessageBox.Show("Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                if (carreras.Agregar(tbName.Text, tbCode.Text, Double.Parse(tbPrecio.Text)))
                {
                    MessageBox.Show("Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {

            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                if (treeView1.SelectedNode != null)
                {
                    var nodo = treeView1.SelectedNode;
                    treeView1.Nodes.Remove(nodo);
                    lbCarrera.Items.Add(nodo.Text);
                }
            }
        }
    }
}
