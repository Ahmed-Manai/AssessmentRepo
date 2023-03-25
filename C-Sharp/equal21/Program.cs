public class A
{
    public bool Test(int i, int j)
    {
        return (i  == 1|| j == 1|| i + j == 1);
    }
}


public class Prog
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new A().Test(1, 5));
        Console.WriteLine(new A().Test(2, 3));
        Console.WriteLine(new A().Test(-3, 4));
    }
}