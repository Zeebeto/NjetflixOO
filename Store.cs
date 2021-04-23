using System;
using System.Collections.Generic;

namespace NjetflixOO
{
    public class Store
    {
        public static List<Movies> Unrented;

        public Store(params Movies[] movies)
        {
            Unrented = new List<Movies>(movies);
            
        }
        public void welcome()
        {
            Console.WriteLine("Welcome to NJETFLIX, where movie rents YOU\n");
        }

        public static string doathing()
        {
            return "banananananananana";
        }

        public static List<Movies> getUnrentedlist()
        {
            return Unrented;
        }
    }
}