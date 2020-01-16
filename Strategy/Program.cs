using Strategy.Business;
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Context estrategia = new Context();

            Console.WriteLine("Tipo de imagen a guardar");
            string cTipo = Console.ReadLine();
            Console.WriteLine("Nombre de la imagen");
            string cNombre = Console.ReadLine();

            //Se crea una estrategia dependiendo del tipo de imagen que se envia
            var storage = estrategia.crearStrategia(cTipo);

            //Se guarda el nombre de la imagen, en este caso se imprime
            storage.Save(cNombre);
            
            Console.ReadLine();
        }
    }
}
