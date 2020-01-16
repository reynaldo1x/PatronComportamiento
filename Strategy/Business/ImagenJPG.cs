using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business
{
    public class ImagenJPG : IStorageImage
    {
        public void Save(string name)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.jpg", name));
        }
    }
}
