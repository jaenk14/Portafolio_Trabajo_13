using System;
using CapaEntidades;
using System.Data.SqlClient;
namespace _03_CapaAccesoDatos
{
    public class DAClientes
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DAClientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
            public int Insertar(EntidadCliente cliente)
            {
                int id = 0;

            SqlConnection conn = new SqlConnection(_cadenaConexion);

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            string sentencia = "INSERT INTO CLIENTES(NOMBRE, TELEFONO, DIRECCION)" +
                "VALUES(@NOMBRE, @TELEFONO, @DIRECCION) SELECT @@IDENTITY";

            comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
            comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);

            comando.CommandText = sentencia;

            try
            {
                conn.Open();
                id = Convert.ToInt32( comando.ExecuteScalar());
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Dispose();
                comando.Dispose();
            }
            return id;
            }
        
    }
}
