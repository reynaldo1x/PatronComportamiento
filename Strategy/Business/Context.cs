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
        private IStorageImage storage;
        private string name = string.Empty;

        public void SetContext(IStorageImage _storageImage)
        {
            storage = _storageImage;
        }

        //Obtenemos el nombre de la imagen
        public void SetName(string _name)
        {
            name = _name;
        }

        public void SaveImageToStorage()
        {
            this.storage.Save(this.name);
        }
        
    }
}
