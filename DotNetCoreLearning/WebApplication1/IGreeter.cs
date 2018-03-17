namespace WebApplication1
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Greetings!";
        }
    }
}