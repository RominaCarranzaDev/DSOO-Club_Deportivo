using PI_Club_Deportivo.Datos;
using PI_Club_Deportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PI_Club_Deportivo
{
    public partial class frmInscripcion : Form
    {
        
        private frmPrincipal principal;

        public frmInscripcion(frmPrincipal principal)
        {
            InitializeComponent();

            this.principal = principal;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumDoc.Text = "";
            txtTel.Text = "";
            dtpFechaNac.Value = DateTime.Today;
            txtEmail.Text = "";
            cboTipoCliente.SelectedIndex = 0;
            cboTipoDni.SelectedIndex = 0;
            chkAptoF.Checked = false;
            txtNombre.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
                txtNumDoc.Text == "" || dtpFechaNac.Value.Date == DateTime.Today.Date ||
                cboTipoCliente.SelectedItem.ToString() == "" || cboTipoDni.Text == "" || chkAptoF.Checked == false)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "Mensaje del sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                E_Cliente cliente;

                if (cboTipoCliente.SelectedItem.ToString() == "Socio")
                {
                    cliente = new E_Socio();
                }
                else
                {
                    cliente = new E_NoSocio();
                }

                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.TipoDoc = (TipoDoc)cboTipoDni.SelectedIndex;
                cliente.Dni = txtNumDoc.Text;
                cliente.Tel = txtTel.Text;
                cliente.Email = txtEmail.Text;
                cliente.FechaNac = DateOnly.FromDateTime(dtpFechaNac.Value);
                cliente.AptoFisico = chkAptoF.Checked;

                Clientes D_Cliente = new Clientes();

                string respuesta = D_Cliente.Nuevo_Cliente(cliente);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo != -1)
                    {
                        MessageBox.Show("Cliente creado con éxito con el Id " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {                        
                        MessageBox.Show("ERROR. EL CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}
