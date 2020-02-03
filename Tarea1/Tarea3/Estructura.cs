using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1.Tarea3
{
    public partial class Estructura : Form
    {
        public Estructura()
        {
            InitializeComponent();
        }

        private void Estructura_Load(object sender, EventArgs e)
        {

        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSeleccionTextBox.Text = ProductoComboBox.Text;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ProductoComboBox.Items.Remove(ProductSeleccionTextBox.Text);
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ProductoComboBox.Items.Add(NombreProductoTextBox.Text);
            NombreProductoTextBox.Clear();
        }
    }
}
