namespace MyFirstConsoleGame_Warriors_
{
    static class Tools
    {
        public static void ColorfulLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
