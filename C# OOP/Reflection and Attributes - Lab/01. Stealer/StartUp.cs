namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            spy.StealFieldInfo("Stealer.Hacker", new string[]{"username", "password"});
        }
    }
}