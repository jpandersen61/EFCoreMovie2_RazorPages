using System;
using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.Interfaces
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovies();

        public IEnumerable<Movie> GetMovies(string title);
    }
}
