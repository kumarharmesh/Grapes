public class DateSettings
{
    public string GetTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}
public class LeapClass2
{
    public bool Compare(int x ,int y)
    {
        return x>y;
    }
     public bool Compare(int x ,int y)
    {
        return x!=y;
    }
    public bool Compare(int x ,int y)
    {
        return x==y;
    }
     public bool Compare(int x ,int y)
    {
        return x<=y;
    }
}

public interface IListing
{
    List<string> ListOfTasks{get;set;}
}

public class Creature
{
    public int life{get;set;}
}
public class Market{}
