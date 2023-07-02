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
    public partial class RegistraPersona : Form
    {
        public RegistraPersona()
        {
            InitializeComponent();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinica_VeterinariaDataSet);

        }

        private void personasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinica_VeterinariaDataSet);

        }

        private void personasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinica_VeterinariaDataSet);

        }

        private void RegistraPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinica_VeterinariaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.clinica_VeterinariaDataSet.Personas);

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)//boton registrar
        {
            Persona persona = new Persona();
            persona.Nombre = nombreTextBox.Text;
            persona.DNI = dNITextBox.Text;
            persona.FamiliaId = int.Parse(familiaIdTextBox.Text);
            persona.PacienteId = int.Parse(pacienteIdTextBox.Text);

            //CrudPersona.AgregarPersona(persona);
            if(CrudPersona.AgregarPersona(persona) > 0)
            {
                MessageBox.Show("Registro agregado correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el registro");
            }
        }
        private void Limpiar()
        {
            nombreTextBox.Clear();
            dNITextBox.Clear();
            familiaIdTextBox.Clear();
            pacienteIdTextBox.Clear();
        }
        

        private void buttonCancelar_Click(object sender, EventArgs e)//boton cancelar
        {
            MessageBox.Show("¿Desea cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Limpiar();
            //this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)//boton modificar
        {
            Persona persona = new Persona();
            persona.Nombre = nombreTextBox.Text;
            persona.DNI = dNITextBox.Text;
            persona.FamiliaId = int.Parse(familiaIdTextBox.Text);
            persona.PacienteId = int.Parse(pacienteIdTextBox.Text);

            //CrudPersona.AgregarPersona(persona);
            if (CrudPersona.EditarPersona(persona) > 0)
            {
                MessageBox.Show("Registro modificado correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el registro");
            }
        }
       

        private void buttonEliminar_Click(object sender, EventArgs e)//boton eliminar
        {
            Persona persona = new Persona();
            persona.Nombre = nombreTextBox.Text;
            persona.DNI = dNITextBox.Text;
            persona.FamiliaId = int.Parse(familiaIdTextBox.Text);
            persona.PacienteId = int.Parse(pacienteIdTextBox.Text);

            //CrudPersona.AgregarPersona(persona);
            if (CrudPersona.EliminarPersona(persona.Id) > 0)
            {
                MessageBox.Show("Registro eliminado correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)//boton nuevo
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//busqueda con radio button id persona y nombre
        {

        }

        //radio button id persona p
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdPersona.Checked == true)
            {
                buttonRegistrar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//radio button nombre
        {
            if (radioButtonNombre.Checked == true)
            {
                buttonRegistrar.Enabled = false;
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
            else
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)// imagen 
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dNILabel_Click(object sender, EventArgs e)
        {

        }

        private void dNITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void familiaIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void familiaIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pacienteIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pacienteIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
