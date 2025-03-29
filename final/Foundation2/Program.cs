using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the Instances of the Product Class.
        Product product1 = new Product(1, "Baby Shark Birthday Postcard", 5.00f, 1);

        Product product2 = new Product(2, "Gaming Chair", 500.00f, 10);

        Product product3 = new Product(3, "Christmas Lights", 20.00f, 2);

        Product product4 = new Product(4, "Pokemon Card Pack", 15.00f, 4);

        Product product5 = new Product(5, "Lighter", 3.00f, 1);

        Product product6 = new Product(6, "Gucci Flip Flops", 150.00f, 1);

        Product product7 = new Product(7, "Maison Francis: Kurkdjian Baccarat Rouge 540", 180.00f, 2);

        // Creates the Instances of the Address Class.
        Address custaddy1 = new Address("5780 East Castle Rd", "Dallas", "TX", "US");

        Address custaddy2 = new Address("VIA CARFIO 400 9/C", "Veneto", "Venice", "Italy");

        Address custaddy3 = new Address("13 East Lindsborg Rd", "Salina", "KS", "US");

        // Creates the Instances of the Customer Class.
        Customer cust1 = new Customer(1, "Maverick Hernandez", custaddy1);

        Customer cust2 = new Customer(2, "Rubio Soares", custaddy2);

        Customer cust3 = new Customer(3, "Mary James", custaddy3);

        // Creates the Instances of the Order Class.
        Order order1 = new Order(product1, product5, custaddy1, cust1);

        Order order2 = new Order(product2, product4, custaddy2, cust2);

        Order order3 = new Order(product3, product6, product7, custaddy3, cust3);

        // Calls the methods on each order which create the Shipping Label, Packing Label, and Display the Total Price of each of them.
        order1.CreateShipLabel();
        order1.CreatePackLabel();
        order1.DisplayTotalPrice();

        order2.CreateShipLabel();
        order2.CreatePackLabel();
        order2.DisplayTotalPrice();

        order3.CreateShipLabel();
        order3.CreatePackLabel();
        order3.DisplayTotalPrice();

    }
}