using _06._Code_Tracker;
using AuthorProblem;

[Author("Victor")]
class StartUp
{
    [Author("George")]
    static void Main(string[] args)
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}