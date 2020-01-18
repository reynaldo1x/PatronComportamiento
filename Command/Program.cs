using Command.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name, option = string.Empty;
            

            //Invocador
            Invoker inv = new Invoker();
            
            Receptor receptor = new Receptor();
            CommandA CA = new CommandA(receptor);
            CommandB CB = new CommandB(receptor);
            CommandC CC = new CommandC(receptor);
            CommandD CD = new CommandD(receptor);

            inv.SetCommand(CA);
            inv.SetCommand(CB);
            inv.SetCommand(CC);
            inv.SetCommand(CD);

            Console.WriteLine("Bienvenido vaquero, cual es tu nombre?");
            name = Console.ReadLine();

            do
            {
                //Console.Clear();
                Console.WriteLine(string.Format($"Excelente {name}, escoje cualquier botón (letra) del menú"));
                Console.WriteLine("a => Caminar ");
                Console.WriteLine("b => Brincar ");
                Console.WriteLine("c => Golpear ");
                Console.WriteLine("d => Disparar ");
                option = Console.ReadLine();

                if (!string.IsNullOrEmpty(option))
                    ObtenerData(inv, option.ToUpper());
                else
                {
                    Console.WriteLine("Vaya esperaba un letra del menú");
                }

                Console.WriteLine("");
                
            } while (!string.IsNullOrEmpty(option));                     


            Console.ReadLine();
        }

        public static void ObtenerData(Invoker _inv, string opt)
        {

            switch (opt)
            {
                case "A":
                    _inv.Get(0).EjecutarComando();
                    break;
                case "B":
                    _inv.Get(1).EjecutarComando();
                    break;
                case "C":
                    _inv.Get(2).EjecutarComando();
                    break;
                case "D":
                    _inv.Get(3).EjecutarComando();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Vaya esperaba un letra del menú");

                    break;
            }

        }
    }
}
