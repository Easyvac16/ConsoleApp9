using System.Security.AccessControl;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            string searchWord = args[1];

            if (!Directory.Exists(filePath))
            {
                Console.WriteLine($"Папку {filePath} не знайдено.");
                return;
            }

            var directories = Directory.GetDirectories(filePath);
            var files = Directory.GetFiles(filePath);

            int matchingFoldersCount = directories.Count(dir => Path.GetFileName(dir).Contains(searchWord));
            int matchingFilesCount = files.Count(file => Path.GetFileName(file).Contains(searchWord));

            Console.WriteLine($"Кількість папок з назвою '{searchWord}': {matchingFoldersCount}");
            Console.WriteLine($"Кількість файлів з назвою '{searchWord}': {matchingFilesCount}");
        }
        static int CountOccurrences(string text, string word)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(word, index)) != -1)
            {
                index += word.Length;
                count++;
            }

            return count;
        }
    }
}