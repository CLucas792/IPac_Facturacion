using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }
        string Operacion;
        Producto producto = new Producto();
        ProductoDB productodb = new ProductoDB();
        DataTable dt = new DataTable();
        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            HabilitarControles();
            Operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            DescripciontextBox.Enabled = true;
            ExistenciatextBox.Enabled = true;
            PreciotextBox.Enabled = true;
            AdjuntarImagenbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Nuevobutton.Enabled = false;
            EstaActivocheckBox.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            ExistenciatextBox.Clear();
            PreciotextBox.Clear();
            EstaActivocheckBox.Checked = false;
        }

        private void DeshabilitarControles()
        {
            CodigotextBox.Enabled = false;
            DescripciontextBox.Enabled = false;
            ExistenciatextBox.Enabled = false;
            PreciotextBox.Enabled = false;
            AdjuntarImagenbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;
            EstaActivocheckBox.Enabled = false;
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DeshabilitarControles();
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            Operacion = "Modificar";
            if (ProductosdataGridView.SelectedRows.Count != 0)
            {
                CodigotextBox.ReadOnly = true;
                CodigotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripciontextBox.Text = ProductosdataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                ExistenciatextBox.Text = ProductosdataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                PreciotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(ProductosdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productodb.DevolverImagen(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (img.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    FotopictureBox.Image = Bitmap.FromStream(ms);
                }
                HabilitarControles();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }

        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigotextBox.Text))
            {
                errorProvider1.SetError(CodigotextBox, "Ingrese un codigo");
                CodigotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Ingrese una descripcion");
                DescripciontextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (Operacion == "Nuevo")
            {

                // Insertar en BD
                producto.Codigo = CodigotextBox.Text;
                producto.Descripcion = DescripciontextBox.Text;
                producto.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
                producto.Precio = Convert.ToDecimal(PreciotextBox.Text);
                producto.EstaActivo = EstaActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    producto.Imagen = ms.GetBuffer();
                }
                bool inserto = productodb.Insertar(producto);
                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerProductos();
                    MessageBox.Show("Registro guardado con exito");
                }
                else
                {
                    MessageBox.Show("Error al guardar registro");
                }


            }
            else
            {
                producto.Codigo = CodigotextBox.Text;
                producto.Descripcion = DescripciontextBox.Text;
                producto.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
                producto.Precio = Convert.ToDecimal(PreciotextBox.Text);
                producto.EstaActivo = EstaActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    producto.Imagen = ms.GetBuffer();
                }

                bool modifico = productodb.Editar(producto);
                if (modifico)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro modificado con existo");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
                }
            }
        }

        private void ExistenciatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(ExistenciatextBox, "Ingrese valores numericos");
            }
        }

        private void PreciotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PreciotextBox, "Ingrese valores numericos");

            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();

            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
            DeshabilitarControles();
        }

        private void TraerProductos()
        {
            ProductosdataGridView.DataSource = productodb.DevolverProductos();

        }

        private void AdjuntarImagenbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dialogoResult = dialog.ShowDialog();

            if (dialogoResult == DialogResult.OK)
            {
                FotopictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("SEGURO DE ELIMINAR ESTE REGISTO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
            {

            }
            else
            {

                if (ProductosdataGridView.SelectedRows.Count != 0)
                {
                    bool elimino = productodb.Eliminar(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                    if (elimino)
                    {
                        TraerProductos();
                        MessageBox.Show("Registo eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
        }
    }
}
