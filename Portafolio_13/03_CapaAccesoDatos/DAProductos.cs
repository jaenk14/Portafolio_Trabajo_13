using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;

namespace _03_CapaAccesoDatos
{
    public class DAProductos
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DAProductos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;

            
        }

        public int insertar(EntidadProductos Producto)
        {
            int id = 0;

            SqlConnection conn = new SqlConnection(_cadenaConexion);

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            string sentencia = "INSERT INTO PRODUCTOS(DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO)" +
                "VALUES(@DESCRIPCION, @PRECIOCOMPRA, @PRECIOVENTA, @GRAVADO) SELECT @@IDENTITY";

            comando.Parameters.AddWithValue("@DESCRIPCION", Producto.Descripcion);
            comando.Parameters.AddWithValue("@PRECIOCOMPRA", Producto.Preciocompra);
            comando.Parameters.AddWithValue("@PRECIOVENTA", Producto.PrecioVenta);
            comando.Parameters.AddWithValue("@GRAVADO", Producto.Gravado);

            comando.CommandText = sentencia;

            try
            {
                conn.Open();
                id =  Convert.ToInt32(comando.ExecuteScalar());
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
