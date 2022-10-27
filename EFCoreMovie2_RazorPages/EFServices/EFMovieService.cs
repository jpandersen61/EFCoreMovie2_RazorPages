using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie2_RazorPages.Interfaces;
using System.Linq;

namespace EFCoreMovie2_RazorPages.EFServices
{
    public class EFMovieService : IMovieService
    {
        private MovieDBContext context;
        public EFMovieService(MovieDBContext service)   
        {
            context = service;
        }
        public IEnumerable<Movie> GetMovies()
        {
            return context.Movies;
        }

        public IEnumerable<Movie> GetMovies(string title)
        {
            return context.Movies.Where(c => c.Title.StartsWith(title)).ToList();
        }
    }
}
