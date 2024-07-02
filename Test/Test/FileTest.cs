using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class FileTest
    {
        private readonly string _filePath;
        private readonly Dictionary<string, int> _wordCounts;

        public FileTest(string filePath)
        {
            _filePath = filePath;
            _wordCounts = new Dictionary<string, int>();
            CountWordFrequencies();
        }

        // Method to read the file and count word frequencies
        private void CountWordFrequencies()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(_filePath);

            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ', ',', '.', '-', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string lowerWord = word.ToLower();
                    if (_wordCounts.ContainsKey(lowerWord))
                    {
                        _wordCounts[lowerWord]++;
                    }
                    else
                    {
                        _wordCounts[lowerWord] = 1;
                    }
                }
            }
        }

        // Method to display the word frequencies
        public void DisplayWordFrequencies()
        {
            var sortedWordCounts = _wordCounts.OrderByDescending(w => w.Value).ThenBy(w => w.Key);

            foreach (var wordCount in sortedWordCounts)
            {
                Console.WriteLine($"{wordCount.Key} {wordCount.Value}");
            }
        }
    }
}
