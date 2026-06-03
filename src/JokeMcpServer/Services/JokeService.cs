public interface IJokeService
{
    string TellNerdyJoke(string input);
    string TellDadJoke(string input);
}

public class JokeService : IJokeService
{
    private static string[] DadJokes =
    [
        "Why did the scarecrow win an award? Because he was outstanding in his field!",
        "Why did the bicycle fall over? Because it was two-tired!",
        "What do you call fake spaghetti? An impasta!",
    ];

    private static string[] NerdyJokes =
    [
        "Why don't scientists trust atoms? Because they make up everything!",
        "Why did the math book look sad? Because it had too many problems!",
        "The average person is really mean."
    ];

    public string TellNerdyJoke(string input)
    {
        var random = new Random();
        int index = random.Next(NerdyJokes.Length);
        return NerdyJokes[index];
    }

    public string TellDadJoke(string input)
    {
        var random = new Random();
        int index = random.Next(DadJokes.Length);
        return DadJokes[index];
    }
}
