using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Optional_Palamarciuc_Dina_ECTS.Models;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Data
{
    public class Proiect_Optional_Palamarciuc_Dina_ECTSContext : DbContext
    {
        public Proiect_Optional_Palamarciuc_Dina_ECTSContext (DbContextOptions<Proiect_Optional_Palamarciuc_Dina_ECTSContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Optional_Palamarciuc_Dina_ECTS.Models.Angajat> Angajat { get; set; } = default!;

        public DbSet<Proiect_Optional_Palamarciuc_Dina_ECTS.Models.Studii> Studii { get; set; }
    }
}
