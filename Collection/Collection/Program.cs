using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
            Lists();
            Sets();
        }

        static void Arrays()
        {
            int[] ints = new int[5];

            int[] ints2 = new int[] { 1, 2, 3, 9, 50 };


            int[][] twoDArray = new int[9][];
            twoDArray[0] = new int[4];
            twoDArray[1] = new int[4];


            int[,] multiDArray = new int[5, 5];

            multiDArray[0, 0] = 8;

            int[,,,] fourDArray = new int[5, 5, 4, 2];
        }


        static void Lists()
        {
            var list = new ArrayList();
            list.Add(5);
            list.Add(8);
            list.Add(1);
            list.AddRange(new int[] { 4, 5, 6, 7, 8 });

            list.Remove(8);
            list.Contains(8);


            for (int i =0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            var genericList = new List<int> { 1,2,3};

            genericList.Add(12456);

            foreach (var item in genericList)
            {
                Console.WriteLine(item * 2);
            }
        }

        static void Sets()
        {
            var set = new HashSet<string>();

            set.Add("abc");
            set.Add("abc");
            set.Add("abcdef");


            Console.WriteLine(set.Count);

            var list = new List<int> { 1, 2, 2, 2, 3 };
            var withoutDupes = new List<int>(new HashSet<int>(list));

        }

        static void Maps()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary["cool"] =  "beans";

            var grades = new Dictionary<string, double>();
            grades["nick"] = 80;

            foreach (var item in grades)
            {
                //has the key and the value so can cycle by each.
            }
        }

        static void stringequality()
        {
            string a = "asdf";
            string b = "asdf";
            Console.WriteLine(a == b);//returns true

            int n1 = 5;
            int n2 = n1;




        }

    }
}

