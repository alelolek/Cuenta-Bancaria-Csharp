
namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] strings) 
        {
            cuentaBancaria cbCarla = new cuentaBancaria("Carla", 10000, DateTime.Now );
            Console.WriteLine($"Felicitaciones acaba de crear su cuenta ({cbCarla.Numero}) con : {cbCarla.Balance }");
            cbCarla.HacerDeposito(400, DateTime.Now, "Cobro de deuda 001");
            Console.WriteLine("Estimado "+ cbCarla.Propietario+" su balance es: " +cbCarla.Balance);
            cbCarla.HacerDeposito(600, DateTime.Now, "Cobro de deuda 002");
            Console.WriteLine("Estimado " + cbCarla.Propietario + " su balance es: " + cbCarla.Balance);
            cbCarla.Retiro(200, DateTime.Now, "Para compra de materiales de escritorio");
            Console.WriteLine("Estimado " + cbCarla.Propietario + " su balance es: " + cbCarla.Balance);
            Console.WriteLine("------------HISTORIAL DE CUENTA---------------");
            Console.WriteLine(cbCarla.traerHistorial());
            Console.WriteLine($"Balance final : {cbCarla.Balance}");

            Console.WriteLine("\n****************************************************\n\n");

            cuentaBancaria cbMaria = new cuentaBancaria("Maria", 4000, DateTime.Now);
            Console.WriteLine($"Felicitaciones acaba de crear su cuenta ({cbMaria.Numero}) con : {cbMaria.Balance}");
            cbMaria.HacerDeposito(300, DateTime.Now, "Cobro de deuda 001");
            Console.WriteLine("Estimado " + cbMaria.Propietario + " su balance es: " + cbMaria.Balance);
            cbMaria.HacerDeposito(400, DateTime.Now, "Cobro de deuda 002");
            Console.WriteLine("Estimado " + cbMaria.Propietario + " su balance es: " + cbMaria.Balance);
            cbMaria.Retiro(800, DateTime.Now, "Para compra de materiales de escritorio");
            Console.WriteLine("Estimado " + cbMaria.Propietario + " su balance es: " + cbMaria.Balance);
            Console.WriteLine("------------HISTORIAL DE CUENTA---------------");
            Console.WriteLine(cbMaria.traerHistorial());
            Console.WriteLine($"Balance final : {cbMaria.Balance}");


            Console.ReadKey();  

        }
    }
}