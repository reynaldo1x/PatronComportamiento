using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Business
{
    public class Observador : IObservador
    {
        public void Submit()
        {
            Console.WriteLine("Se han subido los cambios.");
        }

        public void Compile()
        {
            Console.WriteLine("Compilación finalizada.");
        }

        public void UnitTest()
        {
            Console.WriteLine("Las pruebas han finalizado con exito!.");
        }

        public void Install()
        {
            Console.WriteLine("Se instalo la nueva versión.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Se le ha enviado un correo al cliente.");
        }

        public void Envia()
        {
            this.Submit();
            this.Compile();
            this.UnitTest();
            this.Install();
            this.SendEmail();
        }
    }
}
