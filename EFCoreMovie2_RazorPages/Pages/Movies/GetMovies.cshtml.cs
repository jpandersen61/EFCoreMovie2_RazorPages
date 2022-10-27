using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreMovie2_RazorPages.Interfaces;

namespace EFCoreMovie2_RazorPages.Pages.Movies
{
    public class GetMoviesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        private IMovieService service;

        public GetMoviesModel(IMovieService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Movies = service.GetMovies(FilterCriteria);
            }
            else
                Movies = service.GetMovies();
        }
        public void OnPost()
        {

        }
    }
}