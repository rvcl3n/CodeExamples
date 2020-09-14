using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    class Anagram
    {
        static public int CountWords(string words)
        {
            Console.WriteLine(words);
            string[] wordsArray = words.Split(' ');
            List<string> sortedList = new List<string>();
            int anagramCount = 1;

            foreach (var item in wordsArray)
            {
                char[] loc = item.ToCharArray();

                Array.Sort(loc);

                StringBuilder sb = new StringBuilder();

                foreach (var elem in loc)
                {
                    sb.Append(elem);
                }

                sortedList.Add(sb.ToString());
                sb.Clear();
            }

            wordsArray = sortedList.ToArray();

            Array.Sort(wordsArray);

            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (i == wordsArray.Length-1)
                {
                    Console.WriteLine(wordsArray[i] + " - " + anagramCount);
                }
                else 
                {
                    if (wordsArray[i] == wordsArray[i + 1])
                    {
                        anagramCount++;
                    }
                    else
                    {
                        Console.WriteLine(wordsArray[i] + " - " + anagramCount);
                        anagramCount = 1;
                    }
                }         
            }

            return anagramCount;
        }
    }
}
