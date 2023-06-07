using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class EntidadDetalleFactura
    {
        #region atributos
        private int id_cliente;
        private int id_factura;
        private int cantidad;
        #endregion

        #region metodos
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        #endregion

        #region constructores
        public EntidadDetalleFactura()
        {
            id_cliente = 0;
            id_factura = 0;
            cantidad = 0;
        }

        public EntidadDetalleFactura(int id_cliente,int id_factura, int cantidad)
        {
            this.id_cliente = id_cliente;
            this.id_factura = id_factura;
            this.cantidad = cantidad;
        }
        #endregion

    }
}
