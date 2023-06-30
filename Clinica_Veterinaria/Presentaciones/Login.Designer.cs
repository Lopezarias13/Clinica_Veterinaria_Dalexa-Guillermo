namespace Clinica_Veterinaria.Presentaciones
{
    partial class Login
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
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label passwordLabel;
            this.clinica_VeterinariaDataSet = new Clinica_Veterinaria.Clinica_VeterinariaDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            userLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clinica_VeterinariaDataSet
            // 
            this.clinica_VeterinariaDataSet.DataSetName = "Clinica_VeterinariaDataSet";
            this.clinica_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.clinica_VeterinariaDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacorasTableAdapter = null;
            this.tableAdapterManager.FamiliasTableAdapter = null;
            this.tableAdapterManager.HistorialMedicoSetTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Veterinaria.Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            userLabel.Location = new System.Drawing.Point(418, 107);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(48, 21);
            userLabel.TabIndex = 7;
            userLabel.Text = "User:";
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "User", true));
            this.userTextBox.Location = new System.Drawing.Point(422, 154);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(240, 20);
            this.userTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            passwordLabel.Location = new System.Drawing.Point(423, 193);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(86, 21);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(422, 232);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica_Veterinaria.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(75, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(422, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(576, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinica_VeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Clinica_VeterinariaDataSet clinica_VeterinariaDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Clinica_VeterinariaDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private Clinica_VeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}