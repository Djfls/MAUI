using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.ViewModel
{
    public class NaviPopupViewModel : Prism.Mvvm.BindableBase
    {
        private int _count = 0;
        private string _message = "";

        public string Title { get; set; } = "MainPage";
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value, nameof(Count));
        }
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value, nameof(Message));
        }

    }
}
