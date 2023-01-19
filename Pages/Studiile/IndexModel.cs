using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Data;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models.ViewModels;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Pages.Studiile
{
    [DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
    public class IndexModel : PageModel
    {
        private readonly Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext _context;

        public IndexModel(Proiect_Optional_Palamarciuc_Dina_ECTS.Data.Proiect_Optional_Palamarciuc_Dina_ECTSContext context)
        {
            _context = context;
        }

        public IList<Studii> Studii { get; set; } = default!;

        public StudiiIndexData StudiiData { get; set; }
        public int SudiiID { get; set; }
        public int AngajatID { get; set; }
        public int StudiiIndexData { get; private set; }

        public async Task OnGetAsync(int? id, int? angajatID)
        {
            StudiiData = new StudiiIndexData();
            StudiiData.Studiile = await _context.Studii
                .Include(i => i.Angajati)
                   .ThenInclude(c => c.Nume)
                .OrderBy(keySelector: id => id.CNP)
                .ToListAsync();

            if (id != null)
            {
                StudiiIndexData = id.Value;
                Studii studii = StudiiData.Studiile
                    .Where(i => i.ID == id.Value).Single();
                StudiiData.Angajati = studii.Angajati;

            }
        }

        public override bool Equals(object? obj)
        {
            return obj is IndexModel model &&
                   DebuggerDisplay == model.DebuggerDisplay;
        }

#pragma warning disable CS8603 // Possible null reference return.
        private string DebuggerDisplay => ToString();
    }
#pragma warning restore CS8603 // Possible null reference return.
}
