using System;


class Variables
{
    static string var = "Created Variable";
    public static void run()
    {
        Console.WriteLine("");
        Console.WriteLine(var);

        var = "Changed Variable";

        Console.WriteLine(var);
        Console.WriteLine("");
    }
}
