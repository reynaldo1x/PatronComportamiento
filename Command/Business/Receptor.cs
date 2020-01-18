using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business
{
    public class Receptor
    {

        public void Operacion(string param)
        {
            switch (param)
            {
                case "A":
                    Console.WriteLine("Caminando..");
                    break;
                case "B":
                    Console.WriteLine("brinca..");
                    break;
                case "C":
                    Console.WriteLine("golpeando..");
                    break;
                case "D":
                    Console.WriteLine("disparando..");
                    break;
                case "E":
                    Console.WriteLine("ha lanzado una granada..");
                    break;
                case "F":
                    Console.WriteLine("disparando con rifle de plasma..");
                    break;
                default:
                    Console.WriteLine("valio..");
                    break;
            }
        }
    }
}
