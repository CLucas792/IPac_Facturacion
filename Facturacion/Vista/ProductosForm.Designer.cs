namespace Vista
{
    partial class ProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.AdjuntarImagenbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ProductosdataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(104, 13);
            this.CodigotextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(148, 24);
            this.CodigotextBox.TabIndex = 1;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(104, 45);
            this.DescripciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(148, 24);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(104, 77);
            this.ExistenciatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(148, 24);
            this.ExistenciatextBox.TabIndex = 5;
            this.ExistenciatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciatextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(104, 109);
            this.PreciotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(148, 24);
            this.PreciotextBox.TabIndex = 7;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.BackColor = System.Drawing.Color.White;
            this.FotopictureBox.Location = new System.Drawing.Point(259, 12);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(156, 128);
            this.FotopictureBox.TabIndex = 8;
            this.FotopictureBox.TabStop = false;
            // 
            // AdjuntarImagenbutton
            // 
            this.AdjuntarImagenbutton.Image = ((System.Drawing.Image)(resources.GetObject("AdjuntarImagenbutton.Image")));
            this.AdjuntarImagenbutton.Location = new System.Drawing.Point(390, 146);
            this.AdjuntarImagenbutton.Name = "AdjuntarImagenbutton";
            this.AdjuntarImagenbutton.Size = new System.Drawing.Size(25, 26);
            this.AdjuntarImagenbutton.TabIndex = 9;
            this.AdjuntarImagenbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(339, 179);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 23;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Enabled = false;
            this.Eliminarbutton.Location = new System.Drawing.Point(258, 179);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(177, 179);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Enabled = false;
            this.Modificarbutton.Location = new System.Drawing.Point(83, 179);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(88, 23);
            this.Modificarbutton.TabIndex = 20;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(2, 179);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 19;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ProductosdataGridView
            // 
            this.ProductosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView.Location = new System.Drawing.Point(2, 208);
            this.ProductosdataGridView.Name = "ProductosdataGridView";
            this.ProductosdataGridView.Size = new System.Drawing.Size(421, 205);
            this.ProductosdataGridView.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 417);
            this.Controls.Add(this.ProductosdataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AdjuntarImagenbutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button AdjuntarImagenbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView ProductosdataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}