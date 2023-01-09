public class Subscriber
{
    Message msg=new Message ();
    public NewFile()
    {
        msg.MsgEvent+=handler;
    }
    public handler(string m)
    {
        Console.WriteLine(m);
    }
}
public class Book{}
public class Pen{}