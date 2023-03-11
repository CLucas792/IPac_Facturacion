using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            CodigoUsuariotextBox.Focus();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();

            if (ContraseñatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            //Validar Usuario en la base de datos
            Login login = new Login(CodigoUsuariotextBox.Text, ContraseñatextBox.Text);
            UsuarioDB usuarioDB = new UsuarioDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticar(login);

            //Si son correctos mandarlos al menu
            if (usuario != null)
            {

                //TEMPORAL
                if (usuario.EstadoActivo)
                {
                    MenuForm menuFormulario = new MenuForm();
                    this.Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario esta inactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContraseñatextBox.PasswordChar == '*')
            {
                ContraseñatextBox.PasswordChar = (char)0;
                ContraseñatextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñatextBox.PasswordChar = '*';
            }
        }
    }
}
