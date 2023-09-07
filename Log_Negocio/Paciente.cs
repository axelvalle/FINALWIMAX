using System;

public class Paciente : Persona
{
    public DateTime FECHA_INGRESO { get; set; }
    public string ENFERMEDAD_CRONICA { get; set; }

    public Paciente(string cedula, string nombre1, string nombre2, string apellido1, string apellido2, int edad, char sexo, string departamento, DateTime fechaIngreso, string enfermedadCronica)
        : base(cedula, nombre1, nombre2, apellido1, apellido2, edad, sexo, departamento)
    {
        this.FECHA_INGRESO = fechaIngreso;
        this.ENFERMEDAD_CRONICA = enfermedadCronica;
    }
}
