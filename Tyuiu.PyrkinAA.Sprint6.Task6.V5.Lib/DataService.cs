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
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\r', '\n',
                                                            '(', ')', '[', ']', '{', '}', '"', '\'', '-', '—', '–' },
                                                StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                       
                        if (word.Contains('l') || word.Contains('L'))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            
            return result.ToString().Trim();
        }
    }
}