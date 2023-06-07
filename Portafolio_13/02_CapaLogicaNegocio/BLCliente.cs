using System;
using CapaEntidades;
using _03_CapaAccesoDatos;
using System.Data.SqlClient;

namespace _02_CapaLogicaNegocio
{
    public class BLCliente
    {

        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public BLCliente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;

            
        }

        // Metodo para llamar al metodo insertar de la capa3AccesodeDatos

        public int insertar(EntidadCliente cliente)
        {
            int id_cliente = 0;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);

            try
            {
                id_cliente = accesoDatos.Insertar(cliente);
            }
            catch (Exception)
            {

                throw;
            }

            return id_cliente;
        }
    }
}
