using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Data;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Pages.Studiile
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext _context;

        public EditModel(Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Studii Studii { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Studii == null)
            {
                return NotFound();
            }

            var studii =  await _context.Studii.FirstOrDefaultAsync(m => m.ID == id);
            if (studii == null)
            {
                return NotFound();
            }
            Studii = studii;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Studii).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudiiExists(Studii.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudiiExists(int id)
        {
          return _context.Studii.Any(e => e.ID == id);
        }
    }
}
