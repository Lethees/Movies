﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movies>{
                new Movies { Title = "The Dark Knight",     Rating = 8.9f, Year = 2008 },
                new Movies { Title = "The King's Speech",   Rating = 8.0f, Year = 2010 },
                new Movies { Title = "Casablanca",          Rating = 8.5f, Year = 1942 },
                new Movies { Title = "Star Wars V",     Rating = 8.7f, Year = 1980 }
            };

            var query = movies.Where(m => m.Year > 2000).ToList();

            Console.WriteLine(query.Count());

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext()){
                Console.WriteLine(enumerator.Current.Title);
            }
        }
    }
}
