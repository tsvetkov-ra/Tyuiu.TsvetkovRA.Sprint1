using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.TsvetkovRA.Sprint1.Task6.V10.lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var processedWords = new List<string>();

            foreach (string word in words)
            {
                string cleanWord = word.Trim();
                processedWords.Add(ProcessWord(cleanWord));
            }

            return string.Join(" ", processedWords);
        }
        public static string ProcessWord(string word)
        {
            if (string.IsNullOrEmpty(word) || word.Length <= 1)
                return word;
            if (word.Length % 2 == 1)
            {
                int middleIndex = word.Length / 2;
                return word.Remove(middleIndex, 1);
            }

            return word;
        }
        public static string[] ProcessTextToWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Array.Empty<string>();

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Select(ProcessWord).ToArray();
        }
    }
}
