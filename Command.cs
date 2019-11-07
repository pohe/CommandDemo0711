using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDemo0711
{
    public class Command : ICommand
    {
        public bool CanExecute(object parameter)
        {
            // Should return whether or not the command
            // can currently be executed.
            return true;
        }

        public void Execute(object parameter)
        {
            // The code to execute
        }

        public event EventHandler CanExecuteChanged;
    }

}
