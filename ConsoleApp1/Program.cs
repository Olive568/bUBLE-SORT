using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string line = "";
            using (StreamReader sr = new StreamReader("PleaseSort.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
            for(int i = 0; i < words.Count; i++)
            {
                for(int y = 0; y < words.Count - 1; y++)
                {
                   string word1 = words[y];
                   string word2 = words[y + 1];
                    char a = word1[0];
                    char b = word2[0];
                    int a1 = (int)a;
                    int a2 = (int)b;
                    if (a1 > a2)
                    {
                        string temp = words[y];
                        words[y] = words[y + 1];
                        words[y + 1] = temp;
                    }
                    
                }
            }
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
