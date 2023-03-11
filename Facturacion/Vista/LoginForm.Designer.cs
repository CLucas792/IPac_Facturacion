namespace Vista
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoUsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.ImagenpictureBox = new System.Windows.Forms.PictureBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.VerContrabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // CodigoUsuariotextBox
            // 
            this.CodigoUsuariotextBox.Location = new System.Drawing.Point(115, 39);
            this.CodigoUsuariotextBox.Name = "CodigoUsuariotextBox";
            this.CodigoUsuariotextBox.Size = new System.Drawing.Size(178, 24);
            this.CodigoUsuariotextBox.TabIndex = 1;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(115, 86);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(178, 24);
            this.ContraseñatextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Aceptarbutton.Image")));
            this.Aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton.Location = new System.Drawing.Point(115, 116);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(93, 32);
            this.Aceptarbutton.TabIndex = 4;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // ImagenpictureBox
            // 
            this.ImagenpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ImagenpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagenpictureBox.Image")));
            this.ImagenpictureBox.Location = new System.Drawing.Point(299, 12);
            this.ImagenpictureBox.Name = "ImagenpictureBox";
            this.ImagenpictureBox.Size = new System.Drawing.Size(64, 64);
            this.ImagenpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagenpictureBox.TabIndex = 5;
            this.ImagenpictureBox.TabStop = false;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.Image")));
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(218, 116);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(102, 32);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VerContrabutton
            // 
            this.VerContrabutton.BackColor = System.Drawing.Color.Transparent;
            this.VerContrabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerContrabutton.BackgroundImage")));
            this.VerContrabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VerContrabutton.Location = new System.Drawing.Point(299, 87);
            this.VerContrabutton.Name = "VerContrabutton";
            this.VerContrabutton.Size = new System.Drawing.Size(31, 23);
            this.VerContrabutton.TabIndex = 7;
            this.VerContrabutton.UseVisualStyleBackColor = false;
            this.VerContrabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(362, 164);
            this.ControlBox = false;
            this.Controls.Add(this.VerContrabutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.ImagenpictureBox);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoUsuariotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoUsuariotextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.PictureBox ImagenpictureBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button VerContrabutton;
    }
}

