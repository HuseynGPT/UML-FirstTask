#region FactoryMethod


class Logistik
{
    private ITransport transport;

    public void deliver()
    {
        transport.deliver();
    }


}


interface ITransport
{
   public void deliver();
}

class Truck : ITransport
{
    public void deliver()
    {
        Console.WriteLine("truck");
    }
}

class Airplane : ITransport
{
    public void deliver()
    {
        Console.WriteLine("airplane");
    }
}

#endregion


