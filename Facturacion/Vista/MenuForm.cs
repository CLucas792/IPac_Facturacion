using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void UsuariostoolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosform = new UsuariosForm();
            usuariosform.MdiParent = this;
            usuariosform.Show();

        }

        private void ProductostoolStripButton_Click(object sender, EventArgs e)
        {
            ProductosForm productosform = new ProductosForm();
            productosform.MdiParent = this;
            productosform.Show();
        }

        private void NuevaFacturatoolStripButton_Click(object sender, EventArgs e)
        {
            FacturaForm facturaform = new FacturaForm();
            facturaform.MdiParent = this;
            facturaform.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClienteForm clienteform = new ClienteForm();
            clienteform.MdiParent = this;
            clienteform.Show();
        }
    }
}
