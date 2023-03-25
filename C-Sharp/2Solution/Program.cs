// public interface FlyAble 
// {
//     void fly();
// }

// public abstract class AirPlane : FlyAble
// {
//     public abstract void fly();
// }

// public abstract class Bird : FlyAble
// {
//     public abstract void fly();
// }


public class Bi : Bird
{
    public override void fly()
    {
        throw new NotImplementedException();
    }
}
public abstract class AirPlane
{
    public abstract void fly();
}
public abstract class Bird : AirPlane
{
    
}

public class Program 
{
    public static void Main(string[] args)
    {
        var res = new Bi();
    }
}