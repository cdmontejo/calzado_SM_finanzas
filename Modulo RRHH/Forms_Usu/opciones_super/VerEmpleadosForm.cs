using ModuloRRHH.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_RRH.Forms_Usu.opciones_super
{
    public partial class VerEmpleadosForm : Form
    {

        private Conexion conexion = new Conexion();

        public VerEmpleadosForm()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarAreas();
        }
        private void CargarEmpleados(string filtroNombre = "", string filtroArea = "")
        {
            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_empleado AS ID, nombre, cargo, area FROM empleados WHERE cargo = 'Empleado'";

                    if (!string.IsNullOrEmpty(filtroNombre))
                    {
                        query += " AND nombre LIKE @nombre";
                    }
                    if (!string.IsNullOrEmpty(filtroArea) && filtroArea != "Todos")
                    {
                        query += " AND area = @area";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(filtroNombre))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + filtroNombre + "%");
                        }
                        if (!string.IsNullOrEmpty(filtroArea) && filtroArea != "Todos")
                        {
                            cmd.Parameters.AddWithValue("@area", filtroArea);
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEmpleados.DataSource = dt; // Asignar datos al DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAreas()
        {
            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DISTINCT area FROM empleados";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cbxArea.Items.Clear();
                    cbxArea.Items.Add("Todos"); // Opción para ver todos los empleados

                    while (reader.Read())
                    {
                        cbxArea.Items.Add(reader["area"].ToString());
                    }

                    cbxArea.SelectedIndex = 0; // Seleccionar "Todos" por defecto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            string area = cbxArea.SelectedItem.ToString();
            CargarEmpleados(nombre, area);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);

                DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = conexion.GetConnection())
                        {
                            conn.Open();
                            string query = "DELETE FROM empleados WHERE id_empleado = @id";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", idEmpleado);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEmpleados(); // Recargar la lista de empleados
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerEmpleadosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
