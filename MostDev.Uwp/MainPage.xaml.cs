#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Uwp.MainPage.xaml.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

#endregion

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MostDev.Uwp
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //RunSomething();
            //RunSomething();
            //RunSomething();
            //RunSomething();
            //RunSomething();
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase_OnClick");

            Task.Delay(5000).Wait();

            ListView.Items.Add("ButtonBase_OnClick end");
        }

        private async void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase2_OnClick");

            await Task.Delay(5000);

            var client = new HttpClient();
            var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            ListView.Items.Add("ButtonBase2_OnClick end");
        }

        private void ButtonBase3_OnClick(object sender, RoutedEventArgs e)
        {
            ListView.Items.Add("ButtonBase3_OnClick");

            object o;
            object b;

            string ss;
            string sss;
            string.IsNullOrWhiteSpace("assdgkuywegts");

            int i;
            int ii;
            long l;


            Task.Run(() => { RunSomething(); });

            var a = new ConcurrentBag<string>();
            a.Add("s");

            var dict = new Dictionary<int, string>();
            dict[0] = "some string";

            var cDict = new ConcurrentDictionary<int, string>();

            var semSlim = new SemaphoreSlim(0, 1);
            var sem = new Semaphore(0, 1);
            var are = new AutoResetEvent(false);

            are.WaitOne();
            are.Set();


            var cde = new CountdownEvent(10);

            cde.Wait();

            cde.Signal();


            var mre = new ManualResetEvent(false);

            mre.WaitOne();

            mre.Set();


            sem.WaitOne();

            try
            {
                //throw new WhateverException();
            }
            catch (Exception exception)
            {
                throw exception.InnerException;
            }


            sem.Release();

            var list = new List<string>
            {
                "a",
                "B",
                "a",
                "B",
                "a",
                "B",
                "a",
                "B",
                "a",
                "B",
                "a",
                "B",
                "a",
                "B"
            };

            list.AsParallel().AsOrdered();

            foreach (var c in list)
            {
            }

            var options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 100
            };
            Parallel.ForEach(list, options, inputString =>
            {
                lock (list)
                {
                    list.Add("a");
                }
            });


            foreach (var s in list)
            {
            }

            ListView.Items.Add("ButtonBase3_OnClick end");
        }

        private async void RunSomething()
        {
            await Task.Delay(10000);

            ListView.Items.Add("RunSomething end");
        }
    }
}