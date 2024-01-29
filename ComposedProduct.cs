
internal class ComposedProduct : Product
{
    public float Discount { get; set; }
    public List<Product> Products { get; set; }

    public void ToString()
    {
        throw new System.NotImplementedException();
    }

    public void ValueToPay()
    {
        throw new System.NotImplementedException();
    }
}