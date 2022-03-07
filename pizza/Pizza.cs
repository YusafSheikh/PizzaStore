using System;
namespace pizza
{
    class Pizza
    {
        // method
        private string _name;
        private int _price;
        private string _toppings;


        // constructor and parameter
        public Pizza(string name, int price, string toppings)
        {
            _name = name;
            _price = price;
            _toppings = toppings;
        }

        //property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }

        }
        public string Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }

        // override to ToString
        public override string ToString()
        {
            return _name + " " + _price + " " + _toppings;
        }
    }
  }

