using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Store
    {
        private Dictionary<string, string> scriptures;

        public Store()
        {
            scriptures = new Dictionary<string, string>
            {
                { "John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." },
                { "Philippians 4:13", "I can do all things through Christ which strengtheneth me." },
                { "Psalm 23:1", "The Lord is my shepherd; I shall not want." },
                { "Romans 8:28", "And we know that all things work together for good to them that love God, to them who are the called according to his purpose." },
                { "Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths." }
            };
        }

        public Dictionary<string, string> GetScriptures()
        {
            return scriptures;
        }

        public string GetVerse(string key)
        {
            if (scriptures.TryGetValue(key, out string verse))
            {
                return verse;
            }
            return null;
        }
    }
}





   
      