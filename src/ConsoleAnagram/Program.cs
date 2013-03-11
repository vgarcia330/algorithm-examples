using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnagram
{
    class Program
    {
        private static void Main()
        {
            string myletters = "iionqvesprui";
            int length = 8;
            char[] array = myletters.ToCharArray();




            // 1
            // Read and sort dictionary
            var d = Read();

            var list = d.AsQueryable().Where(l => l.Value.Length == length);

            var newValue = new List<string>();
            foreach (var keyValuePair in list.ToList())
            {
                var t = keyValuePair.ToString().ToCharArray();

                foreach (var VARIABLE in t)
                {
                    if (myletters.Contains(VARIABLE))
                    {
                        
                        newValue.Add(keyValuePair.Value);
                        break;
                    }
                }
            }

            var count = list.Count();
            foreach (var keyValuePair in list)
            {
                Console.WriteLine(keyValuePair.Value);
            }

            //var mywordAlphabetized = Alphabetize(myword);
            //string word;
            //if (d.TryGetValue(mywordAlphabetized, out word))
            //{
            //    Console.WriteLine(string.Format("Found word: {0}", word));
            //}

            //else
            //{
            //    Console.WriteLine("Not Found");
            //}




        Console.ReadLine();
        }

        static Dictionary<string, string> Read()
        {
            var d = new Dictionary<string, string>();
            // Read each line
            using (StreamReader r = new StreamReader("enable1.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    // Alphabetize the line for the key
                    // Then add to the value string
                    string a = Alphabetize(line);
                    string v;
                    if (d.TryGetValue(a, out v))
                    {
                        d[a] = v + "," + line;
                    }
                    else
                    {
                        d.Add(a, line);
                    }
                }
            }
            return d;
        }

        static string Alphabetize(string s)
        {
            // Convert to char array, then sort and return
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }



    }
}
