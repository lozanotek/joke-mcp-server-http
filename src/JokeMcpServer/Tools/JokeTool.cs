using ModelContextProtocol.Server;
using System.ComponentModel;

namespace JokeMcpServer.Tools;

[McpServerToolType]
public sealed class JokeTool
{
    
    [McpServerTool(Title = "Tell a nerdy joke")]
    [Description("Tells a random nerdy joke")]
    public static string TellNerdyJoke(
        // Dependencies
        IJokeService jokeService,

        // Input for tool
        string input)
    {
        var nerdyJoke = jokeService.TellNerdyJoke(input);
        return nerdyJoke;
    }

    [McpServerTool(Title = "Tell a dad joke")]
    [Description("Tells a random dad joke")]
    public static string TellDadJoke(
        // Dependencies
        IJokeService jokeService,

        // Input for tool
        string input)
    {
        var dadJoke = jokeService.TellDadJoke(input);
        return dadJoke;
    }
}