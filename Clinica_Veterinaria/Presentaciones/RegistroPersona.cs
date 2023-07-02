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
    public partial class RegistroPersona : Form
    {
        public RegistroPersona()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)// Boton Guardar
        {
            Agregar();
            Limpiar();
        }
        private void Agregar()// Metodo Agregar
        {
            Persona persona = new Persona();
            persona.Nombre = nombreTextBox.Text;
            persona.DNI = dNITextBox.Text;
            persona.FamiliaId = int.Parse(familiaIdTextBox.Text);
            persona.PacienteId = int.Parse(pacienteIdTextBox.Text);
            if(CrudPersona.AgregarPersona(persona) > 0)
            {
                MessageBox.Show("Persona guardada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo guardar la persona");
            }
        }
        private void Limpiar()// Metodo Limpiar
        {
            nombreTextBox.Clear();
            dNITextBox.Clear();
            familiaIdTextBox.Clear();
            pacienteIdTextBox.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)// Boton Cancelar
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)//Boton Eliminar
        {
            Eliminar();//Con el id 
            Limpiar();
        }
        private void Eliminar()// Metodo Eliminar
        {
            Persona persona = new Persona();
            persona.Id = int.Parse(idTextBox.Text);
            if (CrudPersona.EliminarPersona(persona.Id) > 0)
            {
                MessageBox.Show("Persona eliminada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la persona");
            }
        }

        private void dataGridViewListaPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)//Boton Listar
        {
            dataGridViewListaPersona.DataSource = CrudPersona.ListarPersona();
        }
    }
}
