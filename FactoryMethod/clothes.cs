using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class clothes
    {
    }
    class pants:clothes
    {
        public pants()
        {
            Console.WriteLine("Pants is ready");
        }
    }
    class suits : clothes
    {
        public suits()
        {
            Console.WriteLine("Suits is ready");
        }
    }
}
