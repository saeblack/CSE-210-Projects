using System;

namespace ScriptureMemorizer
{
    public static class Display
    {
        public static void ShowVerse(string reference, string verse)
        {
            Console.Clear();
            Console.WriteLine($"{reference}:");
            Console.WriteLine(verse);
        }
    }
}
