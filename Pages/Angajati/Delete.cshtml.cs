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
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext _context;

        public DeleteModel(Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Angajat Angajat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Angajat == null)
            {
                return NotFound();
            }

            var angajat = await _context.Angajat.FirstOrDefaultAsync(m => m.ID == id);

            if (angajat == null)
            {
                return NotFound();
            }
            else 
            {
                Angajat = angajat;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Angajat == null)
            {
                return NotFound();
            }
            var angajat = await _context.Angajat.FindAsync(id);

            if (angajat != null)
            {
                Angajat = angajat;
                _context.Angajat.Remove(Angajat);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
