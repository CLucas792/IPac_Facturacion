using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;
        Cliente cliente = new Cliente();
        ClienteBD clientebd = new ClienteBD();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
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
            IdentidadtextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            DirecciontextBox.Clear();
            CorreotextBox.Clear();
            EstaActivocheckBox.Checked = false;

        }

        private void DeshabilitarControles()
        {
            IdentidadtextBox.Enabled = false;
            NombretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            EstaActivocheckBox.Enabled = false;

            Guardarbutton.Enabled = false;
            FechaNacimientodateTimePicker.Enabled = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            Guardarbutton.Enabled = true;
            tipoOperacion = "Nuevo";
            Modificarbutton.Enabled = false;

        }

        private void HabilitarControles()
        {
            IdentidadtextBox.Enabled = true;
            NombretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            EstaActivocheckBox.Enabled = true;

            Cancelarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdentidadtextBox.Text))
            {
                errorProvider1.SetError(IdentidadtextBox, "Ingrese un codigo");
                IdentidadtextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Ingrese un codigo");
                NombretextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(TelefonotextBox.Text))
            {
                errorProvider1.SetError(TelefonotextBox, "Ingrese un codigo");
                TelefonotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                errorProvider1.SetError(DirecciontextBox, "Ingrese un codigo");
                DirecciontextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(CorreotextBox.Text))
            {
                errorProvider1.SetError(CorreotextBox, "Ingrese un codigo");
                CorreotextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (tipoOperacion == "Nuevo")
            {
                Modificarbutton.Enabled = true;
                cliente.IdCliente = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivocheckBox.Checked;

                bool inserto = clientebd.Insertar(cliente);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerCliente();
                    MessageBox.Show("Registro guardad", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Modificarbutton.Enabled = true;
                cliente.IdCliente = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivocheckBox.Checked;

                bool edito = clientebd.Editar(cliente);
                if (edito)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerCliente();
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("No se pudo actualiar");
                }
            }
        }

        private void TraerCliente()
        {
            DataTable dt = new DataTable();
            dt = clientebd.DevolverClientes();
            ClientedataGridView.DataSource = dt;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            TraerCliente();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";

            if (ClientedataGridView.SelectedRows.Count != 0)
            {
                IdentidadtextBox.Text = ClientedataGridView.CurrentRow.Cells["IdCliente"].Value.ToString();
                NombretextBox.Text = ClientedataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonotextBox.Text = ClientedataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                DirecciontextBox.Text = ClientedataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                CorreotextBox.Text = ClientedataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                FechaNacimientodateTimePicker.Value = Convert.ToDateTime(ClientedataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                EstaActivocheckBox.Checked = Convert.ToBoolean(ClientedataGridView.CurrentRow.Cells["EstaActivo"].Value);

                HabilitarControles();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
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


                if (ClientedataGridView.SelectedRows.Count != 0)
                {
                    bool elimino = clientebd.Eliminar(ClientedataGridView.CurrentRow.Cells["IdCliente"].Value.ToString());
                    if (elimino)
                    {
                        TraerCliente();
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
