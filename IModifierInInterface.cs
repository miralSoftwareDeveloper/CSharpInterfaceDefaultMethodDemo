using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceDefaultMethodDemo
{
    internal interface IModifierInInterface
    {
        public virtual void DefaultMethod()
        {
            Console.WriteLine("I am default method in interface");
        }

        abstract public void Sum();
    }

    internal interface IOverrideDefaultInterfaceMethod:IModifierInInterface
    {
        void IModifierInInterface.DefaultMethod()
        {
            Console.WriteLine("I am an overridden default method");
        }
    
    }
}
