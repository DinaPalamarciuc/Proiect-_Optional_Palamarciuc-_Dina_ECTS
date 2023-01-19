using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Data;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Pages.Studiile
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext _context;

        public DeleteModel(Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Studii Studii { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Studii == null)
            {
                return NotFound();
            }

            var studii = await _context.Studii.FirstOrDefaultAsync(m => m.ID == id);

            if (studii == null)
            {
                return NotFound();
            }
            else 
            {
                Studii = studii;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Studii == null)
            {
                return NotFound();
            }
            var studii = await _context.Studii.FindAsync(id);

            if (studii != null)
            {
                Studii = studii;
                _context.Studii.Remove(Studii);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
