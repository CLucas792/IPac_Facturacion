using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
        UsuarioDB usuariodb = new UsuarioDB();
        Usuario User = new Usuario();


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
            Guardarbutton.Enabled = true;
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
            Guardarbutton.Enabled = false;
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            LimpiarControles();
            DeshabilitarControles();
            // Modificarbutton.Enabled = false;
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

            if (UsuariodataGridView.SelectedRows.Count != 0)
            {
                CodigotextBox.Text = UsuariodataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombretextBox.Text = UsuariodataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñatextBox.Text = UsuariodataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                CorreotextBox.Text = UsuariodataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                RolcomboBox.Text = UsuariodataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                ActivocheckBox.Checked = Convert.ToBoolean(UsuariodataGridView.CurrentRow.Cells["EstaActivo"].Value);
                byte[] img = usuariodb.DevolverImagen(UsuariodataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

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

                bool inserto = usuariodb.Insertar(User);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro guardad", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

            }

            else if (tipoOperacion == "Modificar")
            {
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

                bool edito = usuariodb.Editar(User);
                if (edito)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("No se pudo actualiar");
                }
            }

        }

        private void UsuariosForm_Load(object sender, System.EventArgs e)
        {
            TraerUsuario();
        }

        private void TraerUsuario()
        {
            DataTable dt = new DataTable();
            dt = usuariodb.DevolverUsuario();
            UsuariodataGridView.DataSource = dt;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("SEGURO DE ELIMINAR ESTE REGISTO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
            {

            }
            else
            {


                if (UsuariodataGridView.SelectedRows.Count != 0)
                {
                    bool elimino = usuariodb.Eliminar(UsuariodataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                    if (elimino)
                    {
                        TraerUsuario();
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
