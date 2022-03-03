using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairCount = int.Parse(Console.ReadLine());

            // test - [exam, evaluation]
            // cute - [addorable, charming]

            Dictionary<string, List<string>> synonimList = new Dictionary<string, List<string>>();

            for (int i = 0; i < pairCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                //if (synonimList.ContainsKey(word))
                //{
                //    synonimList[word].Add(synonym);
                //}
                //else
                //{
                //    List<string> newSymList = new List<string>();
                //    newSymList.Add(synonym);

                //    synonimList.Add(word, newSymList);
                //}

                if (!synonimList.ContainsKey(word))
                {
                    synonimList.Add(word, new List<string>());
                }

                synonimList[word].Add(synonym);
            }

            foreach (var item in synonimList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
