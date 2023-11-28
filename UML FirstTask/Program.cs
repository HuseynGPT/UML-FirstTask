#region FactoryMethod


using System.Globalization;

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



#region Adapter

interface IClientInterface
{
    void metod(string data);
}

class Adapter : Service, IClientInterface
{
    private Service adaptee;

    public void metod(string data)
    {
        serviceMetod(data);
    }
}

class Service
{
    public void serviceMetod(string special_data)
    {
        Console.WriteLine(special_data);
    }
}

#endregion





#region Command

interface ICommand
{
    void execute();
}


class SaveCommand : ICommand
{
    public void execute()
    {
        //code
    }
}

class OpenCommand : ICommand
{
    public void execute()
    {
        //code
    }
}

class PrintCommand : ICommand
{
    public void execute()
    {
        //code
    }
}

#endregion
