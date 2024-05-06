using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.DataProvider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Ocr;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace App5
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            //MethodAsync();
            //test.RunTaskAsync(new string[] { "https://ufcpp.net/study/csharp/sp5_awaitable.html", });
            test.RunPseudoAsync(new string[] { "https://ufcpp.net/study/csharp/sp5_awaitable.html", });
        }

        Task<int> task1= new Task<int>(() => { return hoge1(); });
        public async Task MethodAsync() 
        {
            var result = await BlockingAwaitableExtensions.ToBlocking<int>(new Task<int>(() => { return hoge1(); }));
        }

        static int hoge1()
        {
            int n=0;
            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine("hoge1 is called. {0}\n", i);
            //    n = i;
            //}

            return n;
        }
    }
    static public class test 
    {
        public static async void RunTaskAsync(params string[] uriList)
        {
            var client = new WebClient();

            foreach (var uri in uriList)
            {
                var html = await client.DownloadStringTaskAsync(uri);
            }
        }
        public static void RunPseudoAsync(params string[] uriList) 
        {
            AsyncHelper(RunIterator(uriList));
        }
        private static IEnumerable<Task> RunIterator(params string[] uriList) 
        { var client = new WebClient();
            foreach (var item in uriList)
            {
                var task = client.DownloadStringTaskAsync(item);
                if (!task.IsCompleted) 
                {
                    yield return task;
                }
                var html = task.Result;
                //await相当の処理　以上
            }

            yield return null;
        }

        private static void AsyncHelper(IEnumerable<Task> asyncTask)
        {
            var e = asyncTask.GetEnumerator();
            Action a = null;
            a = () => 
            {
                if (e.MoveNext()&&e.Current!=null) 
                {
                    e.Current.ContinueWith(t=>a());
                }
            };
            a();
        }
    }
    class Awatable
    {
        public Awaiter GetAwaiter() { return new Awaiter(); }

    }
    struct Awaiter
    {
        public bool IsCompleted { get; }
        public void OnCompleted(Action comtinuation) { }
        public T GetResult<T>()
        {
            Type barType = typeof(T);
            var bar = (T)Activator.CreateInstance(barType);
            return bar;
        }
    }
    public static class BlockingAwaitableExtensions
    {
        public static BlockingAwaitable<T> ToBlocking<T>(this Task<T> task)
        {
            return new BlockingAwaitable<T>(task);
        }
    }
    public class BlockingAwaitable<T>
    {
        private BlockingAwaiter<T> _awaiter;

        public BlockingAwaitable(Task<T> task)
        {
            _awaiter = new BlockingAwaiter<T>(task);
        }

        public BlockingAwaiter<T> GetAwaiter() { return _awaiter; }
    }
    public class BlockingAwaiter<T> : INotifyCompletion
    {
        private Task<T> _task;

        public BlockingAwaiter(Task<T> task)
        {
            _task = task;
        }
        public bool IsCompleted { get { return true; } }
        public void OnCompleted(Action comtinuation) { }
        public T GetResult()
        {
            _task.Start();//.Wait();
            _task.Wait();
            return _task.Result;
        }
    }
}
