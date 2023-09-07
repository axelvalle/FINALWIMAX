using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
    public class Area
    {
        public string NOMBRE_AREA { get; set; }
        public string TIPO_AREA { get; set; }
        public DateTime REGISTRO { get; set; }

        public Area(string nombreArea, string tipoArea, DateTime registro)
        {
            this.NOMBRE_AREA = nombreArea;
            this.TIPO_AREA = tipoArea;
            this.REGISTRO = registro;
        }
    }
}
