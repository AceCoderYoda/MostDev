#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Threading.Program.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace MostDev.Threading
{
    public class Person : IComparable
    {
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person();
            person.Name = "";

            //JsonManager jsonManager = new JsonManager();
            //jsonManager.

            //Thread thread = new Thread(Start);
            //thread.Start();

            //ThreadPool.QueueUserWorkItem((o) => ScheduleThing());

            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadPool.QueueUserWorkItem((o) => ScheduleThing());
            //}

            // APM
            // EAP

            // TAP
            //Task.Run(() => Start());


            MainAsync().GetAwaiter().GetResult();
            Console.ReadKey();
        }

        private static async Task MainAsync()
        {
            var carName = "golf'--";
            var query = $@"SELECT * 
                        FROM [CarDb].[dbo].[Cars] 
                        WHERE Name = '{carName}'";

            var sql = new SqlConnection();

            var command = sql.CreateCommand();
            command.CommandText = query;


            //var carName = "golf'--";
            //var query = $@"SELECT * 
            //            FROM [CarDb].[dbo].[Cars] 
            //            WHERE Name = '{carName}'";

            var client2 = Activator.CreateInstance<HttpClient>();
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
            }

            var cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Cancel();

            SomeMethod(cancellationTokenSource.Token);


            var client = new HttpClient();
            var messageAsResult = await client.GetAsync("https://www.google.com", cancellationTokenSource.Token);
            var str = await messageAsResult.Content.ReadAsStringAsync();


            var resultGoogle = await client.GetStringAsync("https://www.google.com");


            var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            Console.WriteLine(result);
        }

        private static void SomeMethod(CancellationToken token)
        {
            // do some logic
            token.ThrowIfCancellationRequested();
            // Do some more
        }

        private static void CallBack(object state)
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(500);
            }
        }

        private static void Start()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(500);
            }
        }

        private static void ScheduleThing()
        {
            Thread.Sleep(1000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Hi");
        }
    }
}