using Modulo_RRH.Forms_Usu;
using ModuloRRHH.Data;
using MySql.Data.MySqlClient;

namespace Modulo_RRH
{
    public partial class Form1 : Form
    {

        Conexion conexion = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrase�a = txtContrasenia.Text;

            if (ValidarUsuario(usuario, contrase�a, out string cargo))
            {
                MessageBox.Show("Bienvenido " + usuario, "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cargo == "Supervisor" || cargo == "Gerente")
                {
                    SupervisorForm supervisorForm = new SupervisorForm();
                    supervisorForm.Show();
                }
                else if (cargo == "Due�o")
                {
                    Due�oForm due�oForm = new Due�oForm();
                    due�oForm.Show();
                }

                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                lblMensaje.Text = "Usuario o contrase�a incorrectos";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool ValidarUsuario(string usuario, string contrase�a, out string cargo)
        {
            cargo = "";
            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT Cargo FROM empleados WHERE Nombre = @Usuario AND Contrase�a = @Contrase�a";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrase�a", contrase�a); // No convertir a int

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        cargo = result.ToString();
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
