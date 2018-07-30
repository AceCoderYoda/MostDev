#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Beer.Program.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;
using System.Text;
using System.Threading;

#endregion

namespace MostDev.Beer
{
    /// <summary>
    ///     For inspiration.
    ///     http://99-bottles-of-beer.net/language-csharp-1614.html
    /// </summary>
    internal class Program
    {
        private  const int interval= 1500;
       

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to beer-time!");
            Console.WriteLine("Press the <anykey>");

            Console.ReadKey();

            BeerTime();
        }

        private static void BeerTime()
        {
            for (var i = 99; i > 1;)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i--} bottles of beer on the wall.");
                Console.WriteLine(Environment.NewLine);
                Thread.Sleep(interval);
            }

            Console.WriteLine($"1 bottle of beer on the wall, 1 bottles of beer.");
            Console.WriteLine($"Take 1 down and pass it around, no more bottles of beer on the wall.");
            Console.WriteLine(Environment.NewLine);
            Thread.Sleep(interval);

            Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. ");
            Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");
            Console.WriteLine(Environment.NewLine);
            Thread.Sleep(interval);

            Console.WriteLine("We are done!");
            Console.WriteLine("Press the <anykey>");
            Console.ReadKey();

            BeerTime();
        }

        private static void BeerTime2()
        {
            for (var i = 99; i >= 0;)
                if (i > 1)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {i--} bottles of beer on the wall.");
                    Console.WriteLine(Environment.NewLine);
                    Thread.Sleep(interval);
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{i} bottle of beer on the wall, {i} bottles of beer.");
                    Console.WriteLine($"Take {i--} down and pass it around, no more bottles of beer on the wall.");
                    Console.WriteLine(Environment.NewLine);
                    Thread.Sleep(interval);
                }
                else
                {
                    Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. ");
                    Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");
                    Console.WriteLine(Environment.NewLine);
                    Thread.Sleep(interval);
                }

            Console.WriteLine("We are done!");
            Console.WriteLine("Press the <anykey>");
            Console.ReadKey();
            BeerTime2();
        }

        private static void BeerTime3()
        {
            StringBuilder beerLyric = new StringBuilder();
           var beers =
                (from n in Enumerable.Range(0, 100)
                    select new
                    {
                        Say = n == 0 ? "No more bottles" :
                            (n == 1 ? "1 bottle" : n.ToString() + " bottles"),
                        Next = n == 1 ? "no more bottles" :
                            (n == 0 ? "99 bottles" :
                                (n == 2 ? "1 bottle" : n.ToString() + " bottles")),
                        Action = n == 0 ? "Go to the store and buy some more" :
                            "Take one down and pass it around"
                    }).Reverse();

            foreach (var beer in beers)
            {
                beerLyric.AppendFormat("{0} of beer on the wall, {1} of beer.{2}",
                    beer.Say, beer.Say.ToLower(), Environment.NewLine);
                beerLyric.AppendFormat("{0}, {1} of beer on the wall.{2}",
                    beer.Action, beer.Next, Environment.NewLine);
                beerLyric.AppendLine();
            }

            Console.WriteLine(beerLyric.ToString());

            Console.WriteLine("We are done!");
            Console.WriteLine("Press the <anykey>");
            Console.ReadKey();
            BeerTime3();
        }
    }
}