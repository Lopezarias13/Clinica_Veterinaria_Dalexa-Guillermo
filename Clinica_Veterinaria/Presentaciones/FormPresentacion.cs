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
    public partial class FormPresentacion : Form
    {
        int tiempo = 0;
        public FormPresentacion()
        {
            InitializeComponent();
        }


        private void FormPresentacion_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tiempo < 4000)
            {
                tiempo += 40;
                progressBar1.Value += 1;
            }
            else
            {
                this.Close();
                timer1.Stop();
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
