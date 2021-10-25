using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class fabrica
    {
        public string Name { get; set; }
        public fabrica(string n)
        {
            Name = n;

        }
        public abstract clothes Create();
    }
    class dresspants : fabrica
    {
        public dresspants(string n) : base(n) { }
        public override clothes Create()
        {
            return new pants();
        }
    }
    class dresssuit : fabrica
    {
        public dresssuit(string n) : base(n) { }
        public override clothes Create()
        {
            return new suits();
        }
    }
}
