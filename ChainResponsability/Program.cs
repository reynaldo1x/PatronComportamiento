using ChainResponsability.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var coordinador = new Coordinador();
            var admin = new Administrador();
            //Otro usuario...

            //Decirle al sistema quien es el siguiente en la cadena
            coordinador.SetNext(admin);
            //next(otro)

            Console.WriteLine("Monto");
            var monto = Console.ReadLine();

            coordinador.Procesar(Convert.ToInt32(monto));
            Console.ReadLine();
        }
    }
}
