class Program
    {
        static void Main()
        {
            var cars = Collection.GetCars();
            
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

