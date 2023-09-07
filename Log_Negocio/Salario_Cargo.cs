using System;

namespace Log_Negocio
{
    public class SalarioCargo
    {
        public int CARGO_ID { get; set; }
        public DateTime VALIDO_DESDE { get; set; }
        public decimal SALARIO { get; set; }

        public SalarioCargo(int cargoId, DateTime validoDesde, decimal salario)
        {
            this.CARGO_ID = cargoId;
            this.VALIDO_DESDE = validoDesde;
            this.SALARIO = salario;
        }
    }
}
