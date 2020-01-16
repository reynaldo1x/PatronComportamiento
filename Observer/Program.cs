using Observer.Interface;
using Observer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Client
    {

        public void Main()
        {
            //Se crea la instancia del Observador (suscriptor) 
            //Se crea la instancia del Observador
            var s = new Observador();
            var o = new Observed();

            //Se suscribe 
            o.AddObservador(s);

            //Se envia notificación de los suscriptos
            o.NotifyObservadores();

            Console.ReadLine();
        }

    }

    public class Program
    {      
        public static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
