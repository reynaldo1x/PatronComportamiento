using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business
{

    public class Context
    {
        private IStorageImage _storage;
        public IStorageImage crearStrategia(string store)
        {
            switch (store)
            {
                case "jpg":
                    _storage = new ImagenJPG();
                    break;
                case "png":
                    _storage = new ImagenPNG();
                    break;
                case "gif":
                    _storage = new ImagenGIF();
                    break;
            }

            return _storage;
        }

        public void Save(string name)
        {
            _storage.Save(name);
        }
    }
}
