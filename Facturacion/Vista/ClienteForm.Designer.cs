
namespace Vista
{
    partial class ClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ClientedataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Esta Activo:";
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Enabled = false;
            this.IdentidadtextBox.Location = new System.Drawing.Point(90, 9);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(262, 24);
            this.IdentidadtextBox.TabIndex = 7;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(432, 9);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(505, 24);
            this.NombretextBox.TabIndex = 8;
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Enabled = false;
            this.TelefonotextBox.Location = new System.Drawing.Point(90, 39);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(262, 24);
            this.TelefonotextBox.TabIndex = 9;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(432, 39);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(505, 24);
            this.DirecciontextBox.TabIndex = 10;
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Location = new System.Drawing.Point(90, 71);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(262, 24);
            this.CorreotextBox.TabIndex = 11;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Enabled = false;
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(499, 71);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(133, 24);
            this.FechaNacimientodateTimePicker.TabIndex = 12;
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(748, 78);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 13;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(343, 129);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(82, 36);
            this.Cancelarbutton.TabIndex = 23;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(265, 129);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(72, 36);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(187, 129);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(72, 36);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(97, 129);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(84, 36);
            this.Modificarbutton.TabIndex = 20;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(27, 129);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(64, 36);
            this.Nuevobutton.TabIndex = 19;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ClientedataGridView
            // 
            this.ClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientedataGridView.Location = new System.Drawing.Point(2, 171);
            this.ClientedataGridView.Name = "ClientedataGridView";
            this.ClientedataGridView.Size = new System.Drawing.Size(945, 303);
            this.ClientedataGridView.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 475);
            this.Controls.Add(this.ClientedataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdentidadtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClienteForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox CorreotextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView ClientedataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}