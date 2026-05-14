using MySqlConnector;
using PI_Club_Deportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Club_Deportivo.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;

            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value =cliente.Apellido;
                comando.Parameters.Add("p_tipoDoc", MySqlDbType.VarChar).Value = cliente.TipoDoc;
                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = cliente.Dni;
                comando.Parameters.Add("p_direccion", MySqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("p_tel", MySqlDbType.VarChar).Value = cliente.Tel;
                comando.Parameters.Add("p_email", MySqlDbType.VarChar).Value = cliente.Email;
                comando.Parameters.Add("p_fechaNac", MySqlDbType.VarChar).Value = cliente.FechaNac;
                comando.Parameters.Add("p_esSocio", MySqlDbType.Bool).Value = cliente is E_Socio;

                MySqlParameter Rta = new MySqlParameter();
                Rta.ParameterName = "rta";
                Rta.MySqlDbType = MySqlDbType.Int32;
                Rta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(Rta);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(Rta.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
            return salida;
        }
    }
}
