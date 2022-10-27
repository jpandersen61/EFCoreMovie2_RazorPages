using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreMovie2_RazorPages.Interfaces;

namespace EFCoreMovie2_RazorPages.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        private IStudioService service;

        public GetStudiosModel(IStudioService service)
        {
            this.service = service;
        }
        public Studio Studio { get; set; }
        public IEnumerable<Studio> Studios { get; set; } = new List<Studio>();
        public void OnGet()
        {
            if (!String.IsNullOrEmpty(FilterCriteria))
            {
                Studios = service.GetStudios(FilterCriteria);
            }
            else
            {
                Studios = service.GetStudios();
            }
        }
        public void OnPost()
        {

        }
    }
}