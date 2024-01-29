internal class VariablePriceProduct : Product
{
    public string Measurement { get; set; }
    public float Quantity { get; set; }

    public void ToString()
    {
        throw new System.NotImplementedException();
    }

    public void ValueToPay()
    {
        throw new System.NotImplementedException();
    }
}