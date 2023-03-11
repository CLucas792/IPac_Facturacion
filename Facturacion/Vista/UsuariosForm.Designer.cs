namespace Vista
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivocheckBox = new System.Windows.Forms.CheckBox();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.AdjuntarImagenbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.UsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Location = new System.Drawing.Point(122, 2);
            this.CodigotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(132, 22);
            this.CodigotextBox.TabIndex = 1;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(122, 32);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(132, 22);
            this.NombretextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Enabled = false;
            this.ContraseñatextBox.Location = new System.Drawing.Point(122, 62);
            this.ContraseñatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(132, 22);
            this.ContraseñatextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Location = new System.Drawing.Point(122, 92);
            this.CorreotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(132, 22);
            this.CorreotextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.Enabled = false;
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox.Location = new System.Drawing.Point(122, 128);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(121, 24);
            this.RolcomboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Activo";
            // 
            // ActivocheckBox
            // 
            this.ActivocheckBox.AutoSize = true;
            this.ActivocheckBox.Enabled = false;
            this.ActivocheckBox.Location = new System.Drawing.Point(122, 171);
            this.ActivocheckBox.Name = "ActivocheckBox";
            this.ActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.ActivocheckBox.TabIndex = 11;
            this.ActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.BackColor = System.Drawing.Color.White;
            this.FotopictureBox.Location = new System.Drawing.Point(261, 2);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(110, 112);
            this.FotopictureBox.TabIndex = 12;
            this.FotopictureBox.TabStop = false;
            // 
            // AdjuntarImagenbutton
            // 
            this.AdjuntarImagenbutton.Enabled = false;
            this.AdjuntarImagenbutton.Image = ((System.Drawing.Image)(resources.GetObject("AdjuntarImagenbutton.Image")));
            this.AdjuntarImagenbutton.Location = new System.Drawing.Point(348, 120);
            this.AdjuntarImagenbutton.Name = "AdjuntarImagenbutton";
            this.AdjuntarImagenbutton.Size = new System.Drawing.Size(23, 24);
            this.AdjuntarImagenbutton.TabIndex = 13;
            this.AdjuntarImagenbutton.UseVisualStyleBackColor = true;
            this.AdjuntarImagenbutton.Click += new System.EventHandler(this.AdjuntarImagenbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(4, 208);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(89, 208);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 15;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(170, 208);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(251, 208);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(332, 208);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 18;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // UsuariodataGridView
            // 
            this.UsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView.Location = new System.Drawing.Point(4, 237);
            this.UsuariodataGridView.Name = "UsuariodataGridView";
            this.UsuariodataGridView.Size = new System.Drawing.Size(857, 193);
            this.UsuariodataGridView.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 433);
            this.Controls.Add(this.UsuariodataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AdjuntarImagenbutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.ActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ActivocheckBox;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button AdjuntarImagenbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView UsuariodataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}