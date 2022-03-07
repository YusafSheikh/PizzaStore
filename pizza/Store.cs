using System;
namespace pizza
{
    public class Store
    {
        public void Start()
        {
            // method + parameters
            Pizza p1 = new Pizza("Københavner", 65, "agurk toppings");
            Pizza p2 = new Pizza("Mozeralla", 59, "ekstra ost");
            Pizza p3 = new Pizza("Ananas Pizza", 70, "med ekstra kød");

            Customer c1 = new Customer(12,"Frederik","frederik@gmail.com", 22456523);
            Customer c2 = new Customer(43,"Mathias", "Mathiashaj@hotmail.com", 54325323);
            Customer c3 = new Customer(23,"Søren","regnesøren@live.dk", 86342354);

            Order o1 = new Order(12, p1, c1);
            Order o2 = new Order(54, p2, c2);
            Order o3 = new Order(32, p3, c3);

            Console.WriteLine(o1);
            Console.ReadLine();
        }
    }
}
