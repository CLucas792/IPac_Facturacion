using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripEx1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClientestoolStripButton_Click(object sender, System.EventArgs e)
        {

        }

        private void UsuariostoolStripButton_Click(object sender, System.EventArgs e)
        {
            UsuariosForm UserForm = new UsuariosForm();
            UserForm.MdiParent = this;
            UserForm.Show();
        }

        private void ProductostoolStripButton_Click(object sender, System.EventArgs e)
        {
            ProductosForm ProductosForm = new ProductosForm();
            ProductosForm.MdiParent = this;
            ProductosForm.Show();
        }
    }
}
