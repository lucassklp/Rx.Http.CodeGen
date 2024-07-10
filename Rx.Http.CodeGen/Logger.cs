public static class Logger {

    public static bool IsVerbose {get; set;}

    public static void Log(string? message) 
    {
        if(!string.IsNullOrEmpty(message))
        {
            Console.WriteLine(message);
        }
    }

    public static void Log(string? message, ConsoleColor color) 
    {
        Console.ForegroundColor = color;
        Log(message);
        Console.ResetColor();
    }

    public static void LogVerbose(string? message) 
    {
        if(IsVerbose)
        {
            Log(message);
        }
    }

    public static void LogVerbose(Func<string?> message) 
    {
        if(IsVerbose)
        {
            Log(message.Invoke());
        }
    }

    public static void LogVerbose(string? message, ConsoleColor color) 
    {
        if(IsVerbose)
        {
            Log(message, color);
        }
    }
}