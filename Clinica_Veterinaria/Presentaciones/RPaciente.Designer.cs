namespace Clinica_Veterinaria.Presentaciones
{
    partial class RPaciente
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
            System.Windows.Forms.Label property1Label;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label especieLabel;
            System.Windows.Forms.Label razaLabel;
            System.Windows.Forms.Label colorDePeloLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label pesoMedioLabel;
            System.Windows.Forms.Label pesoActualLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clinica_VeterinariaDataSet = new Clinica_Veterinaria.Clinica_VeterinariaDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager();
            this.property1TextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.especieTextBox = new System.Windows.Forms.TextBox();
            this.razaTextBox = new System.Windows.Forms.TextBox();
            this.colorDePeloTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.pesoMedioTextBox = new System.Windows.Forms.TextBox();
            this.pesoActualTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonIdPersona = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            property1Label = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            aliasLabel = new System.Windows.Forms.Label();
            especieLabel = new System.Windows.Forms.Label();
            razaLabel = new System.Windows.Forms.Label();
            colorDePeloLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            pesoMedioLabel = new System.Windows.Forms.Label();
            pesoActualLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(property1Label);
            this.groupBox1.Controls.Add(this.property1TextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(aliasLabel);
            this.groupBox1.Controls.Add(this.aliasTextBox);
            this.groupBox1.Controls.Add(especieLabel);
            this.groupBox1.Controls.Add(this.especieTextBox);
            this.groupBox1.Controls.Add(razaLabel);
            this.groupBox1.Controls.Add(this.razaTextBox);
            this.groupBox1.Controls.Add(colorDePeloLabel);
            this.groupBox1.Controls.Add(this.colorDePeloTextBox);
            this.groupBox1.Controls.Add(fechaNacimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNacimientoTextBox);
            this.groupBox1.Controls.Add(pesoMedioLabel);
            this.groupBox1.Controls.Add(this.pesoMedioTextBox);
            this.groupBox1.Controls.Add(pesoActualLabel);
            this.groupBox1.Controls.Add(this.pesoActualTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Paciente";
            // 
            // clinica_VeterinariaDataSet
            // 
            this.clinica_VeterinariaDataSet.DataSetName = "Clinica_VeterinariaDataSet";
            this.clinica_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.clinica_VeterinariaDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacorasTableAdapter = null;
            this.tableAdapterManager.FamiliasTableAdapter = null;
            this.tableAdapterManager.HistorialMedicoSetTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.PersonasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // property1Label
            // 
            property1Label.AutoSize = true;
            property1Label.Location = new System.Drawing.Point(22, 76);
            property1Label.Name = "property1Label";
            property1Label.Size = new System.Drawing.Size(86, 20);
            property1Label.TabIndex = 2;
            property1Label.Text = "Property1:";
            // 
            // property1TextBox
            // 
            this.property1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Property1", true));
            this.property1TextBox.Location = new System.Drawing.Point(171, 73);
            this.property1TextBox.Name = "property1TextBox";
            this.property1TextBox.Size = new System.Drawing.Size(100, 27);
            this.property1TextBox.TabIndex = 3;
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(22, 109);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(67, 20);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(171, 106);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 27);
            this.codigoTextBox.TabIndex = 5;
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Location = new System.Drawing.Point(22, 142);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(47, 20);
            aliasLabel.TabIndex = 6;
            aliasLabel.Text = "Alias:";
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Alias", true));
            this.aliasTextBox.Location = new System.Drawing.Point(171, 139);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(100, 27);
            this.aliasTextBox.TabIndex = 7;
            // 
            // especieLabel
            // 
            especieLabel.AutoSize = true;
            especieLabel.Location = new System.Drawing.Point(22, 175);
            especieLabel.Name = "especieLabel";
            especieLabel.Size = new System.Drawing.Size(68, 20);
            especieLabel.TabIndex = 8;
            especieLabel.Text = "Especie:";
            // 
            // especieTextBox
            // 
            this.especieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Especie", true));
            this.especieTextBox.Location = new System.Drawing.Point(171, 172);
            this.especieTextBox.Name = "especieTextBox";
            this.especieTextBox.Size = new System.Drawing.Size(100, 27);
            this.especieTextBox.TabIndex = 9;
            // 
            // razaLabel
            // 
            razaLabel.AutoSize = true;
            razaLabel.Location = new System.Drawing.Point(22, 208);
            razaLabel.Name = "razaLabel";
            razaLabel.Size = new System.Drawing.Size(46, 20);
            razaLabel.TabIndex = 10;
            razaLabel.Text = "Raza:";
            // 
            // razaTextBox
            // 
            this.razaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Raza", true));
            this.razaTextBox.Location = new System.Drawing.Point(171, 205);
            this.razaTextBox.Name = "razaTextBox";
            this.razaTextBox.Size = new System.Drawing.Size(100, 27);
            this.razaTextBox.TabIndex = 11;
            // 
            // colorDePeloLabel
            // 
            colorDePeloLabel.AutoSize = true;
            colorDePeloLabel.Location = new System.Drawing.Point(22, 241);
            colorDePeloLabel.Name = "colorDePeloLabel";
            colorDePeloLabel.Size = new System.Drawing.Size(113, 20);
            colorDePeloLabel.TabIndex = 12;
            colorDePeloLabel.Text = "Color De Pelo:";
            // 
            // colorDePeloTextBox
            // 
            this.colorDePeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "ColorDePelo", true));
            this.colorDePeloTextBox.Location = new System.Drawing.Point(171, 238);
            this.colorDePeloTextBox.Name = "colorDePeloTextBox";
            this.colorDePeloTextBox.Size = new System.Drawing.Size(100, 27);
            this.colorDePeloTextBox.TabIndex = 13;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(22, 274);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(143, 20);
            fechaNacimientoLabel.TabIndex = 14;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoTextBox
            // 
            this.fechaNacimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoTextBox.Location = new System.Drawing.Point(171, 271);
            this.fechaNacimientoTextBox.Name = "fechaNacimientoTextBox";
            this.fechaNacimientoTextBox.Size = new System.Drawing.Size(100, 27);
            this.fechaNacimientoTextBox.TabIndex = 15;
            // 
            // pesoMedioLabel
            // 
            pesoMedioLabel.AutoSize = true;
            pesoMedioLabel.Location = new System.Drawing.Point(22, 307);
            pesoMedioLabel.Name = "pesoMedioLabel";
            pesoMedioLabel.Size = new System.Drawing.Size(100, 20);
            pesoMedioLabel.TabIndex = 16;
            pesoMedioLabel.Text = "Peso Medio:";
            // 
            // pesoMedioTextBox
            // 
            this.pesoMedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "PesoMedio", true));
            this.pesoMedioTextBox.Location = new System.Drawing.Point(171, 304);
            this.pesoMedioTextBox.Name = "pesoMedioTextBox";
            this.pesoMedioTextBox.Size = new System.Drawing.Size(100, 27);
            this.pesoMedioTextBox.TabIndex = 17;
            // 
            // pesoActualLabel
            // 
            pesoActualLabel.AutoSize = true;
            pesoActualLabel.Location = new System.Drawing.Point(22, 340);
            pesoActualLabel.Name = "pesoActualLabel";
            pesoActualLabel.Size = new System.Drawing.Size(98, 20);
            pesoActualLabel.TabIndex = 18;
            pesoActualLabel.Text = "Peso Actual:";
            // 
            // pesoActualTextBox
            // 
            this.pesoActualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "PesoActual", true));
            this.pesoActualTextBox.Location = new System.Drawing.Point(171, 337);
            this.pesoActualTextBox.Name = "pesoActualTextBox";
            this.pesoActualTextBox.Size = new System.Drawing.Size(100, 27);
            this.pesoActualTextBox.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.radioButtonIdPersona);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(463, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 63);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Clinica_Veterinaria.Properties.Resources.busqueda1;
            this.button2.Location = new System.Drawing.Point(590, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 37);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 3;
            // 
            // radioButtonIdPersona
            // 
            this.radioButtonIdPersona.AutoSize = true;
            this.radioButtonIdPersona.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdPersona.Location = new System.Drawing.Point(160, 29);
            this.radioButtonIdPersona.Name = "radioButtonIdPersona";
            this.radioButtonIdPersona.Size = new System.Drawing.Size(107, 24);
            this.radioButtonIdPersona.TabIndex = 1;
            this.radioButtonIdPersona.TabStop = true;
            this.radioButtonIdPersona.Text = "Id Paciente";
            this.radioButtonIdPersona.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(463, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 334);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista Paciente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // RPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 482);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RPaciente";
            this.Text = "RPaciente";
            this.Load += new System.EventHandler(this.RPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clinica_VeterinariaDataSet clinica_VeterinariaDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private Clinica_VeterinariaDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox property1TextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox especieTextBox;
        private System.Windows.Forms.TextBox razaTextBox;
        private System.Windows.Forms.TextBox colorDePeloTextBox;
        private System.Windows.Forms.TextBox fechaNacimientoTextBox;
        private System.Windows.Forms.TextBox pesoMedioTextBox;
        private System.Windows.Forms.TextBox pesoActualTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonIdPersona;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}