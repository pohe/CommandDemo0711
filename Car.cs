using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo0711
{
    public class Car
    {
        private string _licensePlate; //Is unique

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set { _brand = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string ImageSource { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public double Price { get; set; }

        public Car()
        {


        }


        public override string ToString()
        {
            return "This is a " + _brand;
        }



    }

}
