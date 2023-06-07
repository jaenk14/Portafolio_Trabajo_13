using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using _03_CapaAccesoDatos;
using System.Data.SqlClient;
namespace _02_CapaLogicaNegocio
{
    public class BLProductos
    {

        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public BLProductos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;

            
        }

        public int insertar(EntidadProductos producto)
        {
            int id_producto = 0;
            DAProductos accesoDatoss = new DAProductos(_cadenaConexion);

            try
            {
                id_producto = accesoDatoss.insertar(producto);
            }
            catch (Exception)
            {

                throw;
            }

            return id_producto;
        }
    }
}
