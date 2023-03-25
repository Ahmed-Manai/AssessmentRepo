public class Answer 
{
    public static bool Check(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in str)
        {
            if (c == '(' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
            {
                return false;
            }
            else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Answer.Check("[()]"));
        Console.WriteLine(Answer.Check("(()[])"));
        Console.WriteLine(Answer.Check("([)]"));
        Console.WriteLine(Answer.Check("(("));

    }
}