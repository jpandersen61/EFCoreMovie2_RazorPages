using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie2_RazorPages.Interfaces;
using System.Linq;

namespace EFCoreMovie2_RazorPages.EFServices
{
    public class EFStudioService : IStudioService
    {
        private MovieDBContext context;
        public EFStudioService(MovieDBContext service)
        {
            context = service;
        }
        public IEnumerable<Studio> GetStudios()
        {
            return context.Studios;
        }

        public IEnumerable<Studio> GetStudios(string name)
        {
            return context.Studios.Where(c => c.Name.StartsWith(name)).ToList(); ;
        }
    }
}
