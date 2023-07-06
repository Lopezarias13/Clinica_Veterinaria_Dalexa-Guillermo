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

        private void buttonRegistrar_Click(object sender, EventArgs e)// Boton Registrar Familia Guardar
        {
            if (CamposVacios())
            {
                MessageBox.Show("Debes completar todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AgregarFamilia();
                Limpiar();
            }
        }

        private bool CamposVacios()// Metodo para validar campos vacios para el registro de una nueva familia
        {
            return string.IsNullOrWhiteSpace(codigoTextBox.Text) ||
                   string.IsNullOrWhiteSpace(apellido1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(property1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(direccionTextBox.Text) ||
                   string.IsNullOrWhiteSpace(telefonoTextBox.Text);
        }

        private void AgregarFamilia()
        {
            if (CamposVacios())
            {
                // No se guardará la información si los campos están vacíos
                return;
            }

            Familia F = new Familia();
            F.Codigo = codigoTextBox.Text;
            F.Apellido1 = apellido1TextBox.Text;
            F.Property1 = property1TextBox.Text;
            F.Direccion = direccionTextBox.Text;
            F.Telefono = telefonoTextBox.Text;

            if (CrudFamilia.AgregarFamilia(F) > 0)
            {
                MessageBox.Show("Familia Registrada con Éxito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Familia", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            //idTextBox.Clear();
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
            //dataGridView1.DataSource = CrudFamilia.ListarFamilia();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)// Boton Nuevo
        {
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonEliminar_Click(object sender, EventArgs e)// Boton Eliminar
        {
            // Obtener el ID de la fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idFamilia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta Familia?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Eliminar la Familia
                    int resultado = CrudFamilia.EliminarFamilia(idFamilia);

                    if (resultado > 0)// Si el resultado es mayor a 0, significa que se eliminó la Familia
                    {
                        MessageBox.Show("¡Familia eliminada exitosamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonModificar_Click(object sender, EventArgs e)// Boton Modificar
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idFamilia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);// Obtener el ID de la fila seleccionada

                // Buscar la familia por su ID
                Familia familia = CrudFamilia.BuscarFamilia(idFamilia);

                if (familia != null)
                {
                    // Asignar los nuevos valores a la familia
                    familia.Codigo = codigoTextBox.Text;
                    familia.Apellido1 = apellido1TextBox.Text;
                    familia.Property1 = property1TextBox.Text;
                    familia.Direccion = direccionTextBox.Text;
                    familia.Telefono = telefonoTextBox.Text;

                    // Guardar los cambios en la base de datos
                    int resultado = CrudFamilia.EditarFAMILIA(familia);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Familia modificada exitosamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la Familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la Familia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)// Es para buscar por ID
        {

        }
        private void radioButtonIdPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdPersona.Checked)
            {
                textBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                button2.Enabled = false;
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)// Boton para buscar por ID
        {
            if (radioButtonIdPersona.Checked) // Verifica si el RadioButton está marcado
            {
                if (int.TryParse(textBox1.Text, out int idFamilia)) // Intenta convertir el texto del TextBox a un valor entero
                {
                    Familia familia = CrudFamilia.BuscarFamilia(idFamilia); // Buscar la familia por ID

                    if (familia != null)
                    {
                        // Crear una lista temporal con la familia encontrada
                        List<Familia> familiasEncontradas = new List<Familia> { familia };

                        // Asignar la lista como origen de datos del DataGridView
                        dataGridView1.DataSource = familiasEncontradas;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la Familia con el ID especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido para el ID de la Familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonoLabel_Click(object sender, EventArgs e)
        {

        }

        private void property1Label_Click(object sender, EventArgs e)
        {

        }

        private void property1TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
