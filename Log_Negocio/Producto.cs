using System;

namespace Log_Negocio
{
    public class Producto
    {
        public Producto(string nombre_producto, DateTime? fecha_vencimiento, string efectos, string informacion)
        {
            NOMBRE_PRODUCTO = nombre_producto;
            FECHA_VECIMIENTO = fecha_vencimiento;
            EFECTOS = efectos;
            INFORMACION = informacion;
        }

        public string NOMBRE_PRODUCTO { get; set; }
        public DateTime? FECHA_VECIMIENTO { get; set; }
        public string EFECTOS { get; set; }
        public string INFORMACION { get; set; }
    }
}
