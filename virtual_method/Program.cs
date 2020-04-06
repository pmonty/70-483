using System;

namespace virtual_method
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.ShowLogo(); // override b logo

            A b = new A();
            b.ShowLogo(); // default virtual logo
        }
    }

    public class A
    {
        public virtual void ShowLogo()
        {
            Console.WriteLine("Default virtual logo");
        }
    }

    public class B: A   
    {
        // override virtual method with new implementation
        public override void ShowLogo()
        {
            Console.WriteLine("override B logo");
        }
    }

    public class C : B
    {
        // showlogo will display "override B logo"

    }

    public class D : A
    {
        // showlogo will display "Default virtual logo"
    }
}
