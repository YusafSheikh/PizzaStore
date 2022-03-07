using System;
namespace pizza
{
    class Customer
    {
   // method
            private int _customerID;
            private string _name;
            private string _mail;
            private int _tlfnummer;

        // constructor and parameter
        public Customer(int customerID, string name, string mail, int tlfnummer)
        {
            _customerID = customerID;
            _name = name;
            _mail = mail;
            _tlfnummer = tlfnummer;
        }
        // properties
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public int Tlfnummer
        {
            get { return _tlfnummer; }
            set { _tlfnummer = value; }
        }
        // ToString
        public override string ToString()
        {
            return _customerID + " " + _name + " " + _mail + " " + _tlfnummer;
        }
    }
}
