public class CollectionOrder
{
    private List<Order> orders = new List<Order>();

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

   public void DisplayOrders()
{
    var orderedOrders = orders.OrderBy(o => o.Table);

    Console.WriteLine("Orders ordered from first to last:");
    foreach (var order in orderedOrders)
    {
        Console.WriteLine($"Table: {order.Table}, Waiter: {order.WaiterName}, Meals: {string.Join(", ", order.MealsOrdered)}, Drinks: {string.Join(", ", order.DrinksOrdered)}");
    }
}


    public void MockData()
    {
        AddOrder(new Order(1, new List<string> { "Burger", "Fries" }, new List<string> { "Coke" }, "John"));
        AddOrder(new Order(2, new List<string> { "Pizza" }, new List<string> { "Water", "Beer" }, "Mary"));
        AddOrder(new Order(3, new List<string> { "Pasta" }, new List<string> { "Wine" }, "Alex"));
    }
}
