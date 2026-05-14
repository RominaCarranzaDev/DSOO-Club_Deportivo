using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Club_Deportivo
{
    public partial class frmPrincipal : Form
    {
        private string? usuario;
        private string? rol;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(string usuario, string rol)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.rol = rol;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola {usuario?.ToUpper() ?? ""} [ {rol ?? ""} ]";

            btnAdmin.Visible = (rol == "administrador");
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion(this);
            inscripcion.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}