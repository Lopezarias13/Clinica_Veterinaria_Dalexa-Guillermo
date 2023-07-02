using Clinica_Veterinaria.Datos;
using Clinica_Veterinaria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Veterinaria.Presentaciones
{
    public partial class RFa : Form
    {
        public RFa()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)// Boton Guardar y Agregar
        {
            AgregarFamilia();
            Limpiar();
        }
        private void AgregarFamilia()// Metodo Agregar
        {
            Familia F = new Familia();
            F.Codigo = codigoTextBox.Text;
            F.Apellido1 = apellido1TextBox.Text;
            F.Property1 = property1TextBox.Text;
            F.Direccion = direccionTextBox.Text;
            F.Telefono = telefonoTextBox.Text;
            if(CrudFamilia.AgregarFamilia(F) > 0)
            {
                MessageBox.Show("Familia Agregada con Exito");
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Familia");
            }
        }
        private void Limpiar()// Metodo Limpiar
        {
            idTextBox.Clear();
            codigoTextBox.Clear();
            apellido1TextBox.Clear();
            property1TextBox.Clear();
            direccionTextBox.Clear();
            telefonoTextBox.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)// Boton Cancelar
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Boton Listar
        {
            dataGridView1.DataSource = CrudFamilia.ListarFamilia();
        }

        private void dataGridViewListaPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RFa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CrudFamilia.ListarFamilia();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)// Boton Eliminar
        {
           
        }

        private void buttonModificar_Click(object sender, EventArgs e)// Boton Modificar
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)// Boton Nuevo
        {

        }
    }
}
