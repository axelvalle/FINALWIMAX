using System;
using System.Collections.Generic;
using System.Text;
namespace Log_Negocio
{
    public class Cargo
    {
        public string NOMBRE_CARGO { get; set; }
        public string ESPECIALIDAD { get; set; }
        public DateTime REGISTRO { get; set; }

        public Cargo(string nombreCargo, string especialidad, DateTime registro)
        {
            this.NOMBRE_CARGO = nombreCargo;
            this.ESPECIALIDAD = especialidad;
            this.REGISTRO = registro;
        }
    }
}
