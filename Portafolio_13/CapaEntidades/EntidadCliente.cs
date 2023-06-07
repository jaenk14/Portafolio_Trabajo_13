using System;

namespace CapaEntidades
{
    public class EntidadCliente
    {
        #region atributos

        private int id_cliente;
        private string nombre;
        private string telefono;
        private string direccion;
        #endregion

        #region Metodos
        public int Id_cliente { get => id_cliente;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        #endregion

        #region Constructores
        public EntidadCliente()
        {
            id_cliente = 0;
            nombre = string.Empty;
            telefono = string.Empty;
            direccion = string.Empty;       
        }

        public EntidadCliente(int id_cliente, string nombre, string telefono, string direccion, bool existe)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            
        }
        #endregion
    }
}
