using System;

namespace CSharpInterfaceDefaultMethodDemo
{
    internal class Program
    {
        static void Main()
        {
            // Bellow code implementation of default method in interface.
            IDefaultInterfaceMethod anyclass = new AnyClass();
            anyclass.DefaultMethod();
            // End

            // Below line will give compile time error 

            //AnyClass anyClass = new AnyClass();
            //anyClass.DefaultMethod();

            // Use of Modifier in Interface

            //IModifierInInterface anyClass = new AnyClass2();
            //anyclass.DefaultMethod();

            //IOverrideDefaultInterfaceMethod anyclass2 = new AnyClass2();
            //anyclass2.DefaultMethod();


        }
    }
}
