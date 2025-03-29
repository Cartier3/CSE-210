using System.ComponentModel.DataAnnotations;

class Order
{
    // Calls instances of the Address and Customer classes so that it can fit within the Order constructors.
    private Address _address;

    private Customer _customer;

    // These lists store all of the products and customers that are entered into the Program, this is so the rest of the methods can run properly.
    List<Product> _products = new List<Product>();

    List <Customer> _customers = new List<Customer>();

    // Constructors for the Order Class. It accomodates orders with at least 2 products or instances with 3 product orders!
    public Order(Product product, Product product2, Address address, Customer customer)
    {
        AddProduct(product);

        AddProduct(product2);

        AddCust(customer);

        _address = address;

        _customer = customer;
    }

    public Order(Product product, Product product2, Product product3, Address address, Customer customer)
    {
        AddProduct(product);

        AddProduct(product2);

        AddProduct(product3);

        AddCust(customer);

        _address = address;

        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddCust(Customer customer)
    {
        _customers.Add(customer);
    }

    public float CalcTotalPrice()
    {
        // This method calculates the total price by calculating the product price in the order with the FindCost() method. It then adds the shipping cost after it checks the country of the address given in the order class instance.
        // It took me a bit to debug this method but basically I originally arranged the code wrong where I had the foreach method add the extra shipping price for each p in the _products list.
        // I had to move the if statements below the foreach loop and then the method worked just like I intended it to. 
        
        float totalPrice = 0.00f;

        bool _ifUS = _address.CheckIfUS();

        foreach(Product p in _products)
        {
            float prodCost = p.FindCost();
            totalPrice += prodCost;
        }

        if (_ifUS == true)
        {
            totalPrice += 5.00f;
        }

        if (_ifUS == false)
        {
            totalPrice += 35.00f;
        }

        return totalPrice;
    }

    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Total Price (Including Shipping Cost): ${CalcTotalPrice()}");
    }

    public void CreateShipLabel()
    {
        Console.WriteLine($"\nName: {_customer.GetName()} || Address: {_address.GetFullAddy()} ");
    }

    public void CreatePackLabel()
    {
        DisplayProducts();
    }


    public void DisplayProducts()
    {
        // This method writes each product and their Id's within the _products list when called.
        
        Console.WriteLine("Packing Label: ");
        
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetStringProd()}");
        }
    }

    public void DisplayCustomers()
    {
        foreach (Customer c in _customers)
        {
            Console.WriteLine($"{c.GetStringCust()}");
        }
    }
}