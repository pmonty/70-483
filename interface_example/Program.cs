using System;

namespace interface_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // a is typeof athlete so need to specify which interface method is being called
            Athlete a = new Athlete();
            ((IFootball)a).Play();
            ((IAfl)a).Play();
            ((IAfl)a).Register();

            // a2 is typeof IAfl so only the afl methods are available
            IAfl a2 = new Athlete();
            a2.Register();
            a2.Play();

            // a3 is typeof IFootball so only the football play method is available
            IFootball a3 = new Athlete();
            a3.Play();
        }
    }

    interface IFootball
    {
        void Play();
    }

    // all methods and properties must be implemented!
    interface IAfl
    {
        void Register();
        void Play();
    }

    class Athlete : IFootball, IAfl
    {
        void IFootball.Play()
        {
            Console.WriteLine("Playing football!");
        }

        void IAfl.Play()
        {
            Console.WriteLine("Playing AFL!");
        }
        
        void IAfl.Register()
        {
            Console.WriteLine("Registered to play AFL!");
        }
    }
}
