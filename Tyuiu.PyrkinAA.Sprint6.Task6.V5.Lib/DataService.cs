using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            List<string> resultWords = new List<string>();

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\r', '\n',
                                                    '(', ')', '[', ']', '{', '}', '"', '\'' };

                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        
                        if (word.Contains('l'))
                        {
                            resultWords.Add(word);
                        }
                    }
                }
            }

           
            return string.Join(" ", resultWords);
        }
    }
}