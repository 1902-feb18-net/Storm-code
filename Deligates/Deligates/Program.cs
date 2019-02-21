using System;

namespace Deligates
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviePlayer = new MoviePlayer
            {
                CurrentMovie = Movie.StarWars4
            };

            MoviePlayer.MovieFinishedHandler handler = EjectDisk;



            moviePlayer.MovieFinished += handler;


            moviePlayer.DiskEjected += (s) => Console.WriteLine($"Ejecting {s}");


            FuncAndAction();


            Console.WriteLine("Playing Movie..");


            moviePlayer.Play();

            Console.ReadLine();
        }
        public static void EjectDisk()
        {
            Console.WriteLine("Ejecting disc.");

        }


        public static void FuncAndAction()
        {
            Func<string, string, int> func = (s1,s2) => s1.Length + s1.Length;
            Action<string, string, int> action = (s1, s2, i) => Console.WriteLine(s1 + s2 + i);
        }
    }
}
