using NLog;
using System;
using System.Collections.Generic;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Number: ");

            var input = Console.ReadLine();

            int number;
            if (int.TryParse(input, out number) == true)
            {
                Console.WriteLine("Number: Entered: " + number);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            var dict = new Dictionary<string, int>();
            if (dict.TryGetValue("nick",out var value))
            {
                //work with the value if it exists.
            }


            int x = 40;
            ChangeMyInt(x);
            Console.WriteLine(x);


            ChangeMyInt(ref x);
            Console.WriteLine(x);

            ILogger logger = LogManager.GetCurrentClassLogger();

            logger.Debug("logger created");
            try
            {
                int.Parse("abc");
            }
            catch(FormatException e)
            {
                logger.Error(e);
            }

            Console.ReadLine();
        }

        public static void ChangeMyInt(int number)
        {
            number = 10;
        }

        public static void ChangeMyInt(ref int number)
        {
            number = 10;
        }
    }
}
