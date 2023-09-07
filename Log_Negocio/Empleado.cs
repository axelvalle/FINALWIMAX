using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
    public class Empleado : Persona
    {
        public int ID_AREA { get; set; }
        public int ID_CARGO { get; set; }
        public DateTime fechaderegistro { get; set; }
        public byte activo { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public Empleado(string cedula, string nombre1, string nombre2, string apellido1, string apellido2, int edad, char sexo, string departamento, int idArea, int idCargo, DateTime fechaRegistro, byte activo,string usuario,string contrasena)
            : base(cedula, nombre1, nombre2, apellido1, apellido2, edad, sexo, departamento)
        {
            this.ID_AREA = idArea;
            this.ID_CARGO = idCargo;
            this.fechaderegistro = fechaRegistro;
            this.activo = activo;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }
    }
}
