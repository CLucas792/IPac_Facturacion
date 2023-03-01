using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
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

            //Si son correctos mandarlos al menu

            Menu menuFormulario = new Menu();
            menuFormulario.Show();
            Close();
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
