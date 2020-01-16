using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interface
{
    public interface IObservador
    {
        void Submit();

        void Compile();

        void UnitTest();

        void Install();

        void SendEmail();
    }
}
