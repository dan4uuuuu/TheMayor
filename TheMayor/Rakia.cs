using System;

public class Rakia
{
    private int _quantity = 3;
    public Rakia()
    {
        Quantity = _quantity;
    }
    public int QuantityIncrement()
    {
        return this.Quantity++;
    }
    public int QuantityDecrement()
    {
        return this.Quantity--;
    }
    internal void FillRakia()
    {
        throw new NotImplementedException();
    }

    public int Quantity { get; set; }
}