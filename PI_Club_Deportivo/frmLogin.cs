using PI_Club_Deportivo.Datos;
using System.Data;

namespace PI_Club_Deportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Usuarios dato = new Usuarios();

            tablaLogin = dato.Login_Usuario(txtUsuario.Text, txtPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                string rol = Convert.ToString(tablaLogin.Rows[0][3]);
                string usuario = txtUsuario.Text;

                frmPrincipal principal = new frmPrincipal(usuario, rol);

                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario...")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario...";
            }
        }
    }
}
