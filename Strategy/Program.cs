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

            //Obtenemos el nombre que le daremos a la imagen
            estrategia.SetName(cNombre);

            //Se crea una estrategia dependiendo del tipo de imagen que se envía
            if (cTipo.Equals("jpg"))           
                estrategia.SetContext(new ImagenJPG());
            if (cTipo.Equals("png"))
                estrategia.SetContext(new ImagenPNG());
            if (cTipo.Equals("gif"))
                estrategia.SetContext(new ImagenGIF());

            //Se guarda la imagen
            estrategia.SaveImageToStorage();

            Console.ReadLine();
        }
    }
}
