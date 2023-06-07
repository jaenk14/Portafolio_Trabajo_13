using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class EntidadEncabezado_Factura
    {
        #region atributos
        private int id_factura;
        private DateTime fecha;
        private int id_cliente;
        private decimal subtotal;
        private decimal impuesto;
        private decimal montoDescuento;
        #endregion

        #region metodos
        public int Id_factuta { get => id_factura; set => id_factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public decimal MontoDescuento { get => montoDescuento; set => montoDescuento = value; }
        #endregion

        #region constructores
        public EntidadEncabezado_Factura()
        {
            id_factura = 0;
            fecha = DateTime.Now;
            id_cliente = 0;
            subtotal = 0;
            impuesto = 0;
            montoDescuento = 0;
        }

        public EntidadEncabezado_Factura(int id_factura, DateTime fecha, int id_cliente, decimal subtotal,
            decimal impuesto, decimal montoDescuento)
        {
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.subtotal = subtotal;
            this.impuesto = impuesto;
            this.montoDescuento = montoDescuento;
        }
        #endregion

    }
}
