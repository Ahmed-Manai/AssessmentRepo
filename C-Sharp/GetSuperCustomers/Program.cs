

public class Order
{
    public string Customer {get; set;}
    public decimal Price {get; set;}

}

public class Program
{
    public static IEnumerable<string> GetSuperCustomers(List<Order> orders)
    {
        return orders.GroupBy(o => o.Customer)
        .Where(c => c.Sum(p => p.Price) > 100m)
        .Select(cos => cos.Key);
    }
}


public class Prog
{
    public static void Main(string[] args)
    {
        var orders = new List<Order>();
        var superCustomers = Program.GetSuperCustomers(orders);

        orders.Add(new Order{Customer = "C3", Price = 125m});
        orders.Add(new Order{Customer = "C2", Price = 150m});
        orders.Add(new Order{Customer = "C1", Price = 50m});
        orders.Add(new Order{Customer = "C1", Price = 25m});

        foreach (var c in superCustomers) Console.WriteLine(c);

    }
}