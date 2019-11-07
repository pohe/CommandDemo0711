using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandDemo0711.Annotations;

namespace CommandDemo0711
{
    public class CarCatalog : INotifyPropertyChanged
    {
        private ObservableCollection<Car> _cars;

        private Car _selectedCar;

        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                OnPropertyChanged();//Hej jeg er blevet ændret
                ((DeleteCommand)_deleteCommand).RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
        }

        public void Delete(string licensePlate)
        {
            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].LicensePlate.Equals(licensePlate))
                {
                    _cars.Remove(_cars[i]);
                    break;
                }
            }
        }

        public CarCatalog()
        {
            _cars = new ObservableCollection<Car>(){new Car() { Brand = "Volvo", LicensePlate="VO 88974",  ImageSource = "/assets/Audi.jpg", Color = "Blue", Price = 2000.2, Seats = 5 },
                new Car() { Brand = "BMW", LicensePlate="AB 12134", ImageSource = "/assets/Fiat.jpg", Color = "Red", Price = 4000, Seats = 6 },
                new Car() { Brand = "Opel", LicensePlate = "ZX 65656", ImageSource = "/assets/Funnycar.jpg", Color = "Yellow", Price = 10000.5, Seats = 5 },
                new Car() { Brand = "Toyota",LicensePlate="TT 56435",  ImageSource = "/assets/formel1.jpg", Color = "White", Price = 500.2, Seats = 1 }};

            _deleteCommand = new DeleteCommand(this);
            //_selectedCar = _cars[0];
        }

        //public ICommand DeleteCommand
        //{
        //    get
        //    {
        //        return new Command();
        //    }
        //}

        private ICommand _deleteCommand;

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
