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
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DeshabilitarControles();
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            Operacion = "Modificar";
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (Operacion == "Nuevo")
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
    }
}
