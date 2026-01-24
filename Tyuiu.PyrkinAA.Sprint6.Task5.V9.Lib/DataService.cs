using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        len++;
                    }
                }
            }

            double[] numsArray = new double[len];
            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    double number = Convert.ToDouble(line);
                    numsArray[index] = Math.Round(number, 3);
                    index++;
                }
            }

            numsArray = numsArray.Where(x => Math.Abs(x) < 0.001).ToArray();

            return numsArray;
        }
    }
}