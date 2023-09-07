using System;

namespace Log_Negocio
{
    public class Citas
    {
        public string EMPLEADO_CEDULA { get; set; }
        public string PACIENTE_CEDULA { get; set; }
        public DateTime REGISTRO_CITA_DESDE { get; set; }
        public DateTime REGISTRO_CITA_HASTA { get; set; }

        // Constructor sin argumentos (predeterminado)
        public Citas()
        {
        }

        // Constructor con argumentos para inicializar todas las propiedades
        public Citas(string empleadoCedula, string pacienteCedula, DateTime registroCitaDesde, DateTime registroCitaHasta)
        {
            EMPLEADO_CEDULA = empleadoCedula;
            PACIENTE_CEDULA = pacienteCedula;
            REGISTRO_CITA_DESDE = registroCitaDesde;
            REGISTRO_CITA_HASTA = registroCitaHasta;
        }
    }
}
