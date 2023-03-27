using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    public class Transaccion
    {
        public decimal Monto{ get; }
        public DateTime Dia { get; }
        public string Nota { get; }

        public Transaccion(decimal monto, DateTime dia, string nota)
        {
            this.Monto = monto;
            this.Dia = dia;
            this.Nota = nota;
        }
    }
}
