using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute) : this(execute, null)
        { }
        public RelayCommand(Action<object> execute, Func<bool> canExcute)
        {
            if (execute == null) { throw new ArgumentException("execute"); }
            _execute = execute;
            _canExecute = canExcute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged() 
        {
        var handler = CanExecuteChanged;
            if (handler!=null) 
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
