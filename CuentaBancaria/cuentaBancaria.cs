using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
     public class cuentaBancaria
    {
        public string Numero { get; }
        public string Propietario { get; }
        public decimal Balance { get
            {
                decimal balance =0;
                foreach (var item in todasTransacciones)
                {
                    balance = balance + item.Monto;
                }
                return balance;
            }
        }

        private static int numeroCuenta = 209;

        private List<Transaccion> todasTransacciones = new List<Transaccion>();

        public cuentaBancaria(string nombre,decimal depositoInicial,DateTime dia) 
        {
            this.Propietario = nombre;
            this.Numero = numeroCuenta.ToString();
            numeroCuenta++;
            HacerDeposito(depositoInicial, dia,"Cuenta de banco inicial");
        }

        public void HacerDeposito(decimal monto,DateTime dia,string nota)
        {
            if(monto < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto),"El monto de deposito no puede ser negativo");
            }

            var deposito = new Transaccion(monto, dia, nota);

            todasTransacciones.Add(deposito);
        }


        public void Retiro(decimal monto, DateTime dia, string nota)
        {
            if(monto<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto de retiro no puede ser negativo");
            }
            if((Balance - monto ) < 0)
            {
                throw new InvalidOperationException( "No cuenta con fondos para esta transaccion");
            }
            var deposito = new Transaccion(-monto, dia, nota);
            todasTransacciones.Add(deposito);
        }

        public string traerHistorial()
        {
            var reporte = new StringBuilder();
            reporte.AppendLine("Dia \t\t\t Monto \t Nota");
            foreach (var item in todasTransacciones)
            {
                reporte.AppendLine($"{item.Dia.ToShortDateString()} \t\t{item.Monto} \t {item.Nota}");
            }
            return reporte.ToString();
        }
    }
}
