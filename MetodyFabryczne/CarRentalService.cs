class CarRentalService
{
    private CarFactory carFactory;
    public CarRentalService(CarFactory carFactory)
    {
        this.carFactory = carFactory;
    }

    public void Rent()
    {
        Vehicle v = carFactory.Create();
        Console.WriteLine("Our service can offer you the following car today: ");
        Console.WriteLine(v);
    }
}