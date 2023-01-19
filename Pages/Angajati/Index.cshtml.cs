using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Data;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Pages.Angajati
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext _context;

        public IndexModel(Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext context)
        {
            _context = context;
        }

        public IList<Angajat> Angajat { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Angajat != null)
            {
                Angajat = await _context.Angajat.ToListAsync();
            }
        }
    }
}
