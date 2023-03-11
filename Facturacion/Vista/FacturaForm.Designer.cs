
namespace Vista
{
    partial class FacturaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ISVtextBox = new System.Windows.Forms.TextBox();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CodigoUsuariotextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // CodigoUsuariotextBox
            // 
            this.CodigoUsuariotextBox.Location = new System.Drawing.Point(78, 25);
            this.CodigoUsuariotextBox.Name = "CodigoUsuariotextBox";
            this.CodigoUsuariotextBox.ReadOnly = true;
            this.CodigoUsuariotextBox.Size = new System.Drawing.Size(209, 26);
            this.CodigoUsuariotextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuscarClientebutton);
            this.groupBox2.Controls.Add(this.NombretextBox);
            this.groupBox2.Controls.Add(this.IdentidadtextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Location = new System.Drawing.Point(78, 25);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(209, 26);
            this.IdentidadtextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(341, 25);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.ReadOnly = true;
            this.NombretextBox.Size = new System.Drawing.Size(574, 26);
            this.NombretextBox.TabIndex = 2;
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarClientebutton.Location = new System.Drawing.Point(293, 28);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(27, 26);
            this.BuscarClientebutton.TabIndex = 3;
            this.BuscarClientebutton.Text = "...";
            this.BuscarClientebutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarClientebutton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CantidadtextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExistenciatextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripciontextBox);
            this.groupBox3.Controls.Add(this.BuscarProductobutton);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProductobutton.Location = new System.Drawing.Point(293, 28);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(27, 26);
            this.BuscarProductobutton.TabIndex = 6;
            this.BuscarProductobutton.Text = "...";
            this.BuscarProductobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(341, 24);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.ReadOnly = true;
            this.DescripciontextBox.Size = new System.Drawing.Size(574, 26);
            this.DescripciontextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Existencia:";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(97, 69);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.ReadOnly = true;
            this.ExistenciatextBox.Size = new System.Drawing.Size(190, 26);
            this.ExistenciatextBox.TabIndex = 9;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(430, 69);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(190, 26);
            this.CantidadtextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(2, 314);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(953, 202);
            this.DetalledataGridView.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "ISV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descuento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "SubTotal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total:";
            // 
            // ISVtextBox
            // 
            this.ISVtextBox.Location = new System.Drawing.Point(262, 525);
            this.ISVtextBox.Name = "ISVtextBox";
            this.ISVtextBox.ReadOnly = true;
            this.ISVtextBox.Size = new System.Drawing.Size(100, 26);
            this.ISVtextBox.TabIndex = 8;
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(90, 522);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(100, 26);
            this.SubTotaltextBox.TabIndex = 9;
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Location = new System.Drawing.Point(510, 528);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(100, 26);
            this.DescuentotextBox.TabIndex = 10;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(702, 528);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 26);
            this.TotaltextBox.TabIndex = 11;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(834, 525);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(109, 29);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.SubTotaltextBox);
            this.Controls.Add(this.ISVtextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoUsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ISVtextBox;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button button1;
    }
}