using System.Runtime.CompilerServices;

class Product
{
   private int _prodId;
   private string _pName;

    private float _pricePU;

    private int _quantity;

    public Product(int prodId, string pName, float pricePU, int quantity)
    {
        _prodId = prodId;

        _pName = pName;

        _pricePU = pricePU;

        _quantity = quantity;
    }

    public float FindCost()
    {
        // This method calculates the Cost of the product order based on the Price per unit and quantity defined in the constructor. 
        
        float cost = _pricePU * _quantity;

        return cost;
    }

    public string GetStringProd()
    {
        return $"{_prodId}- {_pName} (Cost: ${_pricePU}) Quantity: {_quantity}";
    }

}