using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Godfather",
                        ReleaseDate = DateTime.Parse("1972-03-24"),
                        Genre = "Crime",
                        Price = 10.99M
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-07-18"),
                        Genre = "Action",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Inception",
                        ReleaseDate = DateTime.Parse("2010-07-16"),
                        Genre = "Sci-Fi",
                        Price = 12.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
