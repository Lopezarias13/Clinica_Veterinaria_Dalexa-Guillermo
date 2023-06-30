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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
