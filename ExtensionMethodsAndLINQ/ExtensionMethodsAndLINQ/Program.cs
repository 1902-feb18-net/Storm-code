using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result = 3.Pow(3);
            Console.WriteLine(result);

            var list = new List<string>();
            list.Empty();
            var str = list.ToString();

            list.ToList();

            list.AddRange(new string[] { "a", "b", "b", "asdgffdgjdfgg" });

            int sum =0;
            foreach (var s in list)
            {
                sum += s.Length;
            }
            double averageStringLength = sum/list.Count;

            averageStringLength = list.Average(s => s.Length);

            Console.WriteLine(averageStringLength);



            Func<string, int> numberOfAs = x => x.Count(c => c == 'a');
            var numbofAllAs = list.Sum(numberOfAs);
        }
    }
}
