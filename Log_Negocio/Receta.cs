using System;

public class Receta
{
    public string PACIENTE_CEDULA { get; set; }
    public int ID_PRODUCTO_RECETA { get; set; }
    public int CANTIDAD { get; set; }

    public Receta(string pacienteCedula, int idProductoReceta, int cantidad)
    {
        this.PACIENTE_CEDULA = pacienteCedula;
        this.ID_PRODUCTO_RECETA = idProductoReceta;
        this.CANTIDAD = cantidad;
    }
}
