using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public static class Quiz
    {
        private static Random random = new Random();

        public static string GenerateQuiz(string verse)
        {
            string[] words = verse.Split(' ');
            List<int> availableIndices = words
                .Select((word, index) => new { word, index })
                .Where(item => item.word != "____")
                .Select(item => item.index)
                .ToList();

            if (availableIndices.Count == 0)
            {
                return verse;
            }

            int count = Math.Min(3, availableIndices.Count);

            for (int i = 0; i < count; i++)
            {
                int indexToHide = availableIndices[random.Next(availableIndices.Count)];
                availableIndices.Remove(indexToHide);
                words[indexToHide] = "____";
            }

            return string.Join(" ", words);
        }
    }
}
