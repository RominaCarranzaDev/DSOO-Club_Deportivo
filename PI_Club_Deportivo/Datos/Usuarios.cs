using MySqlConnector;
using PI_Club_Deportivo.Datos;
using System.Data;

namespace PI_Club_Deportivo.Datos
{
    internal class Usuarios
    {
        public DataTable Login_Usuario(string p_usuario, string p_pass)
        {
            DataTable tabla = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_usuario", MySqlDbType.VarChar).Value = p_usuario;

                comando.Parameters.Add("p_pass", MySqlDbType.VarChar).Value = p_pass;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}