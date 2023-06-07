using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadProductos
    {

        #region atributos
        private int id_producto;
        private string descripcion;
        private decimal preciocompra;
        private decimal precioVenta;
        private int gravado;
        #endregion

        #region metodos
        public int Id_producto { get => id_producto; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Preciocompra { get => preciocompra; set => preciocompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Gravado { get => gravado; set => gravado = value; }
        #endregion

        #region constructores
        public EntidadProductos()
        {
            id_producto = 0;
            descripcion = string.Empty;
            preciocompra = 0;
            precioVenta = 0;
            gravado = 0;
        }

        public EntidadProductos(int id_producto, string descripcion, decimal preciocompra, decimal precioventa, int gravado)
        {
            this.id_producto = id_producto;
            this.descripcion = descripcion;
            this.preciocompra = preciocompra;
            this.precioVenta = precioventa;
            this.gravado = gravado;
        }
        #endregion
    }
}
