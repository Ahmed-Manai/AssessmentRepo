public class A
{
    public static int ClosestToZero(int[] ints)
    {
        // if (ints == null || ints.Length == 0) return 0;

        // int res = ints[0];
        // foreach(int i in ints)
        // {
        //     if (Math.Abs(i) < Math.Abs(res) || Math.Abs(i) == Math.Abs(res) && i > 0)
        //     res = i;
        // }
        return ints?.OrderBy(Math.Abs).ThenByDescending(i => i).FirstOrDefault() ?? 0;
    }
}

public class program
{
    public static void Main(string[] args)
    {
        int[] ints = {-11, -5, -2, -8, -2, -10};
        int result = A.ClosestToZero(ints);
        Console.WriteLine(result);
        
    }
}