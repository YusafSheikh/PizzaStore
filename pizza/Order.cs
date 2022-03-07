using System;
namespace pizza
{
    class Order
    {
        // method
        private int _orderID;
        private double totalprice;
        private Pizza pizza;
        private Customer customer;

        //constructor + parameter
        public Order(int orderID, Pizza pizza, Customer customer)
        {
            _orderID = orderID;
            this.pizza = pizza;
            TotalPrice(this.pizza.Price);
            this.customer = customer;

        }
        // properties
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public void TotalPrice(double price)
        {
            double totalprice = price + 40;
            double taxes = 0.25 * price;
            this.totalprice = totalprice + taxes;
        }

        public double GetTotalprice()

        {
            return this.totalprice;
        }
        // ToString
        public override string ToString()
        { return "orderID" + _orderID + " " + customer + " " + pizza + " " + totalprice + " " + " kr. inklusiv levering "; }
      
            
    }
}
