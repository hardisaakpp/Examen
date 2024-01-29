
internal class Product
{
    public int Description
    {
        get => default;
        set
        {
        }
    }

    public int Id
    {
        get => default;
        set
        {
        }
    }

    public int Price
    {
        get => default;
        set
        {
        }
    }

    public int Tax
    {
        get => default;
        set
        {
        }
    }

    public void ToString()
    {
        throw new System.NotImplementedException();
    }

    public void ValueToPay()
    {
        throw new System.NotImplementedException();
    }

    public static implicit operator Product(FixedPriceProduct v)
    {
        throw new NotImplementedException();
    }
}