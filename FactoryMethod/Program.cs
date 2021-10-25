using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            fabrica fabr = new dresspants("NIKE");
            clothes pants = fabr.Create();
            fabr = new dresspants("Adidas");
            clothes suits = fabr.Create();
        }
    }
}
