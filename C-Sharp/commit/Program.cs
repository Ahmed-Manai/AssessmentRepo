using System;


public class Answer
{
public void Run(Service s, Connection c)
{
    
    try 
    {
        s.SetConnection(c);
        s.Execute();
        c.Commit();
    }
    catch (Exception e)
    {
       try
       {
            c.Rollback();
       }
       catch
       {
        c.Close();
       }
       finally
       {
        throw e;
       }
        
    }
    finally
    {
        c.Close();
    }
}

}

public interface Service
{
    void SetConnection(Connection c);
    void Execute();
}

public interface Connection 
{
    void Commit();
    void Rollback();
    void Close();
}


public class MyService : Service
{
    public void Execute()
    {
       //Console.WriteLine("Execute");
       throw new Exception("Execute");
    }

    public void SetConnection(Connection c)
    {
        Console.WriteLine("SetConnection");
    }
}

public class MyConnection : Connection
{
    public void Commit()
    {
        Console.WriteLine("Commit");
    }

    public void Rollback()
    {
        //Console.WriteLine("Rollback");
        throw new Exception();
    }

    public void Close()
    {
        Console.WriteLine("Close");
    }

}
public class Program 
{
    public static void Main(string[] args)
    {
        new Answer().Run(new MyService(), new MyConnection());
    }
}