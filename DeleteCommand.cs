using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDemo0711
{
    public class DeleteCommand : ICommand
    {
        private CarCatalog _carCatalog;

        public DeleteCommand(CarCatalog carCatalog)
        {
            _carCatalog = carCatalog;
        }

        public  bool CanExecute(object parameter)
        {
            return _carCatalog.SelectedCar != null;
        }

        public  void Execute(object parameter)
        {
            _carCatalog.Delete(_carCatalog.SelectedCar.LicensePlate);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }


        public event EventHandler CanExecuteChanged;
    }

}
