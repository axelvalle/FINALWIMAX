using System;

public class Consulta
{
    public string EMPLEADO_CEDULA { get; set; }
    public string PACIENTE_CEDULA { get; set; }
    public DateTime REGISTRO_CONSULTA { get; set; }
    public string DIAGNOSTICO { get; set; }
    public string PRESION_SANGUINEA { get; set; }
    public string OXIGENO { get; set; }
    public string FRECUENCIA_CARDIACA { get; set; }
    public string PESO { get; set; }
    public string TEMPERATURA { get; set; }
    public string PULSO { get; set; }
    public char HIPOTIROIDISMO { get; set; }

    public Consulta(string empleadoCedula, string pacienteCedula, DateTime registroConsulta, string diagnostico, string presionSanguinea, string oxigeno, string frecuenciaCardiaca, string peso, string temperatura, string pulso, char hipotiroidismo)
    {
        this.EMPLEADO_CEDULA = empleadoCedula;
        this.PACIENTE_CEDULA = pacienteCedula;
        this.REGISTRO_CONSULTA = registroConsulta;
        this.DIAGNOSTICO = diagnostico;
        this.PRESION_SANGUINEA = presionSanguinea;
        this.OXIGENO = oxigeno;
        this.FRECUENCIA_CARDIACA = frecuenciaCardiaca;
        this.PESO = peso;
        this.TEMPERATURA = temperatura;
        this.PULSO = pulso;
        this.HIPOTIROIDISMO = hipotiroidismo;
    }
}
