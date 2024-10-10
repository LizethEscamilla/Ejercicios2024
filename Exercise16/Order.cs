public class Order
{
    public int Table { get; set; }
    public List<string> MealsOrdered { get; set; }
    public List<string> DrinksOrdered { get; set; }
    public string WaiterName { get; set; }

    public Order(int table, List<string> mealsOrdered, List<string> drinksOrdered, string waiterName)
    {
        Table = table;
        MealsOrdered = mealsOrdered;
        DrinksOrdered = drinksOrdered;
        WaiterName = waiterName;
    }
}
