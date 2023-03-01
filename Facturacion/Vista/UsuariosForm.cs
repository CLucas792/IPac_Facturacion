using Entidades;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string tipoOperacion = string.Empty;
        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            HabilitarControles();
            Guardarbutton.Enabled = true;
            tipoOperacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ContraseñatextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            ActivocheckBox.Enabled = true;
            AdjuntarImagenbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ContraseñatextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            ActivocheckBox.Enabled = false;
            AdjuntarImagenbutton.Enabled = false;
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            LimpiarControles();
            DeshabilitarControles();
            Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            CorreotextBox.Clear();
            RolcomboBox.Text = "";
            ActivocheckBox.Checked = false;
            FotopictureBox.Image = null;
        }

        private void AdjuntarImagenbutton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dialogoResult = dialog.ShowDialog();

            if (dialogoResult == DialogResult.OK)
            {
                FotopictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            tipoOperacion = "Modificar";
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese un codigo");
                    CodigotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombretextBox.Text))
                {
                    errorProvider1.SetError(NombretextBox, "Ingrese un nombre");
                    NombretextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ContraseñatextBox.Text))
                {
                    errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                    ContraseñatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(RolcomboBox.Text))
                {
                    errorProvider1.SetError(RolcomboBox, "Seleccione un rol");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario User = new Usuario();
                User.CodigoUsuario = CodigotextBox.Text;
                User.Nombre = NombretextBox.Text;
                User.Contraseña = ContraseñatextBox.Text;
                User.Correo = CorreotextBox.Text;
                User.Rol = RolcomboBox.Text;
                User.EstadoActivo = ActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    User.Foto = ms.GetBuffer();
                }
                // Insertar en la base de datos 

                //

            }

            else if (tipoOperacion == "Modificar")
            {

            }

        }

        private void UsuariosForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
