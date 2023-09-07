using System;
using System.Collections.Generic;
using System.Text;

public class Persona


{
    public string Cedula { get; set; }
    public string Nombre1 { get; set; }
    public string Nombre2 { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public int Edad { get; set; }
    public char Sexo { get; set; }
    public string Departamento { get; set; }

    public Persona(string cedula, string nombre1, string nombre2, string apellido1, string apellido2, int edad, char sexo, string departamento)
    {
        Cedula = cedula;
        Nombre1 = nombre1;
        Nombre2 = nombre2;
        Apellido1 = apellido1;
        Apellido2 = apellido2;
        Edad = edad;
        Sexo = sexo;
        Departamento = departamento;
    }
}
