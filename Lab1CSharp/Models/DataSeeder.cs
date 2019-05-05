using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1CSharp.Models
{
    public class DataSeeder
    {
        public static void Initialize(IntroDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "Titanic",
                    Runtime = 170,
                    Rating = 8.9,
                    Storyline = "Love Story"
                },
                new Movie
                {
                    Title = "Skyfall",
                    Runtime = 190,
                    Rating = 9.2,
                    Storyline = "Action"
                });
            context.SaveChanges();
        }

    }
}