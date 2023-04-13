public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> Complements = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i ++)
        {
            int Complement = target - nums[i];

            if (Complements.ContainsKey(Complement))
            {
                return new int[]{Complements[Complement], i};
            }

            Complements[nums[i]] = i;
        }

        return new int[]{};

    }
}

public class Program
{
    public static void Main(string[] args)
    {

        int[] res = new Solution().TwoSum(new int[]{2,7,11,15}, 9);

        foreach(int i in res) Console.WriteLine(i);
    }
}