using System.Collections.Generic;
using System.Net.Sockets;

namespace NjetflixOO
{
    public class Movies
    {
        public string Title;
        public int Year;
        public int Runtime;
        public int Rentprice;
        public string Director;
        public string Genre;
        public List<Movies> moviesList = new List<Movies>();
        private Movies[] _movies;

        public Movies(string title, int year, int runtime, int rentprice, string director, string genre)
        {
            Title = title;
            Year = year;
            Runtime = runtime;
            Rentprice = rentprice;
            Director = director;
            Genre = genre;
        }
    }
}