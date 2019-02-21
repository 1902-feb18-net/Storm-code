using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Deligates
{
    public class MoviePlayer
    {

        public Movie CurrentMovie { get; set; }



        public delegate void MovieFinishedHandler();

        public event MovieFinishedHandler MovieFinished;
        public event Action<string> DiskEjected;



        public bool Play()
        {
            Thread.Sleep(3000);

            if (MovieFinished != null)
            {
                MovieFinished();
            }

            DiskEjected?.Invoke(CurrentMovie.ToString());
            return true;
        }
    }
}
