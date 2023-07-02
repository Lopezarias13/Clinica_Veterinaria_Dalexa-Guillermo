namespace Clinica_Veterinaria.Presentaciones
{
    partial class RegistraPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label familiaIdLabel;
            System.Windows.Forms.Label pacienteIdLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinica_VeterinariaDataSet = new Clinica_Veterinaria.Clinica_VeterinariaDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.familiaIdTextBox = new System.Windows.Forms.TextBox();
            this.pacienteIdTextBox = new System.Windows.Forms.TextBox();
            this.personasTableAdapter = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager();
            this.radioButtonIdPersona = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            familiaIdLabel = new System.Windows.Forms.Label();
            pacienteIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(9, 129);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 4;
            dNILabel.Text = "DNI:";
            dNILabel.Click += new System.EventHandler(this.dNILabel_Click);
            // 
            // familiaIdLabel
            // 
            familiaIdLabel.AutoSize = true;
            familiaIdLabel.Location = new System.Drawing.Point(9, 168);
            familiaIdLabel.Name = "familiaIdLabel";
            familiaIdLabel.Size = new System.Drawing.Size(54, 13);
            familiaIdLabel.TabIndex = 6;
            familiaIdLabel.Text = "Familia Id:";
            familiaIdLabel.Click += new System.EventHandler(this.familiaIdLabel_Click);
            // 
            // pacienteIdLabel
            // 
            pacienteIdLabel.AutoSize = true;
            pacienteIdLabel.Location = new System.Drawing.Point(9, 212);
            pacienteIdLabel.Name = "pacienteIdLabel";
            pacienteIdLabel.Size = new System.Drawing.Size(64, 13);
            pacienteIdLabel.TabIndex = 8;
            pacienteIdLabel.Text = "Paciente Id:";
            pacienteIdLabel.Click += new System.EventHandler(this.pacienteIdLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(dNILabel);
            this.groupBox1.Controls.Add(this.dNITextBox);
            this.groupBox1.Controls.Add(familiaIdLabel);
            this.groupBox1.Controls.Add(this.familiaIdTextBox);
            this.groupBox1.Controls.Add(pacienteIdLabel);
            this.groupBox1.Controls.Add(this.pacienteIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Persona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(79, 49);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(188, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.clinica_VeterinariaDataSet;
            // 
            // clinica_VeterinariaDataSet
            // 
            this.clinica_VeterinariaDataSet.DataSetName = "Clinica_VeterinariaDataSet";
            this.clinica_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(79, 86);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(188, 20);
            this.nombreTextBox.TabIndex = 3;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(79, 126);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(188, 20);
            this.dNITextBox.TabIndex = 5;
            this.dNITextBox.TextChanged += new System.EventHandler(this.dNITextBox_TextChanged);
            // 
            // familiaIdTextBox
            // 
            this.familiaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "FamiliaId", true));
            this.familiaIdTextBox.Location = new System.Drawing.Point(79, 165);
            this.familiaIdTextBox.Name = "familiaIdTextBox";
            this.familiaIdTextBox.Size = new System.Drawing.Size(188, 20);
            this.familiaIdTextBox.TabIndex = 7;
            this.familiaIdTextBox.TextChanged += new System.EventHandler(this.familiaIdTextBox_TextChanged);
            // 
            // pacienteIdTextBox
            // 
            this.pacienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "PacienteId", true));
            this.pacienteIdTextBox.Location = new System.Drawing.Point(79, 209);
            this.pacienteIdTextBox.Name = "pacienteIdTextBox";
            this.pacienteIdTextBox.Size = new System.Drawing.Size(188, 20);
            this.pacienteIdTextBox.TabIndex = 9;
            this.pacienteIdTextBox.TextChanged += new System.EventHandler(this.pacienteIdTextBox_TextChanged);
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacorasTableAdapter = null;
            this.tableAdapterManager.FamiliasTableAdapter = null;
            this.tableAdapterManager.HistorialMedicoSetTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = this.personasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // radioButtonIdPersona
            // 
            this.radioButtonIdPersona.AutoSize = true;
            this.radioButtonIdPersona.Location = new System.Drawing.Point(5, 27);
            this.radioButtonIdPersona.Name = "radioButtonIdPersona";
            this.radioButtonIdPersona.Size = new System.Drawing.Size(76, 17);
            this.radioButtonIdPersona.TabIndex = 1;
            this.radioButtonIdPersona.TabStop = true;
            this.radioButtonIdPersona.Text = "Id Persona";
            this.radioButtonIdPersona.UseVisualStyleBackColor = true;
            this.radioButtonIdPersona.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(113, 27);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombre.TabIndex = 2;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.radioButtonNombre);
            this.groupBox2.Controls.Add(this.radioButtonIdPersona);
            this.groupBox2.Location = new System.Drawing.Point(363, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica_Veterinaria.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(348, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(192, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 234);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEliminar);
            this.groupBox3.Controls.Add(this.buttonCancelar);
            this.groupBox3.Controls.Add(this.buttonModificar);
            this.groupBox3.Controls.Add(this.buttonRegistrar);
            this.groupBox3.Controls.Add(this.buttonNuevo);
            this.groupBox3.Location = new System.Drawing.Point(363, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(307, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 26);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(403, 19);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 26);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(213, 19);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 26);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(113, 19);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 26);
            this.buttonRegistrar.TabIndex = 1;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(6, 19);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 26);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // RegistraPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistraPersona";
            this.Text = "Registro Persona";
            this.Load += new System.EventHandler(this.RegistraPersona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clinica_VeterinariaDataSet clinica_VeterinariaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private Clinica_VeterinariaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox familiaIdTextBox;
        private System.Windows.Forms.TextBox pacienteIdTextBox;
        private System.Windows.Forms.RadioButton radioButtonIdPersona;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}