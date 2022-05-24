using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceDefaultMethodDemo
{
    internal interface IDefaultInterfaceMethod
    {
        public void DefaultMethod()
        {
            Console.WriteLine("I am a default method in the interface!");
        }
    }
}
