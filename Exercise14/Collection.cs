public static class Collection
{
    public static List<Car> GetCars()
    {
        return new List<Car>
        {
            new Car("Toyota", "Corolla", 2020, "Standard", 15000),
            new Car("Honda", "Civic", 2019, "Manual", 25000),
            new Car("Ford", "Mustang", 2021, "Standard", 10000),
            new Car("Chevrolet", "Malibu", 2018, "Manual", 40000),
            new Car("Tesla", "Model 3", 2022, "Standard", 5000)
        };
    }
}
