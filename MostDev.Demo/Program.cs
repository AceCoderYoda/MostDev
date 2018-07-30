#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Demo.Program.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Threading.Tasks;

#endregion

namespace MostDev.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task.Run(() =>
            {
                var test = new Test();
            });


            Console.ReadKey();
        }
    }

    public class Test
    {
        private bool blaaa;

        public Test()
        {
            Bla();
            Bla();
            Bla();
            Bla();
            Bla();
            Bla();
            Blo();
            Bli();
        }

        public async Task Bla()
        {
            if (blaaa) return;
            blaaa = true;
            Console.WriteLine("Bla Start");
            await Task.Delay(10000);
            Console.WriteLine("Bla Stop");
            blaaa = false;
        }

        public async void Blo()
        {
            Console.WriteLine("Blo Start");
            await Task.Delay(10000);
            Console.WriteLine("Blo Stop");
        }

        public void Bli()
        {
            Console.WriteLine("Bli Start");
            Console.WriteLine("Bli Stop");
        }
    }
}