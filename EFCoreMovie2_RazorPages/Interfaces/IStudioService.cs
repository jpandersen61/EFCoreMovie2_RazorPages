using System;
using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.Interfaces
{
    public interface IStudioService
    {
        public IEnumerable<Studio> GetStudios();
        public IEnumerable<Studio> GetStudios(string name);
    }
}
