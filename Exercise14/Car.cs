public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Type { get; set; } 
    public double Kilometers { get; set; }
    public Car(string brand, string model, int year, string type, double kilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Type = type;
        Kilometers = kilometers;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} ({Year}), {Type} ,{Kilometers} km";
    }
}
