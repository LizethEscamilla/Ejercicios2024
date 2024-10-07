public struct Fighter
{
    public string Name { get; set; }
    public double Weight { get; set; }
    
    public BoxCategories Category
    {
        get
        {
            if (Weight <= 112)
                return BoxCategories.Flyweight;
            else if (Weight <= 118)
                return BoxCategories.Bantamweight;
            else if (Weight <= 126)
                return BoxCategories.Featherweight;
            else if (Weight <= 135)
                return BoxCategories.Lightweight;
            else if (Weight <= 147)
                return BoxCategories.Welterweight;
            else if (Weight <= 160)
                return BoxCategories.Middleweight;
            else if (Weight <= 175)
                return BoxCategories.LightHeavyweight;
            else
                return BoxCategories.Heavyweight;
        }
    }

    public Fighter(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
}
