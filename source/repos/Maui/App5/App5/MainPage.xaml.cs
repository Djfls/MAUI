using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            MethodAsync();
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
