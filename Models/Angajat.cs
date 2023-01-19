using System.ComponentModel.DataAnnotations;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Models
{
    public class Angajat
    {
        public int ID { get; set; }
        [Display(Name = "Nume Angajat")]
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        [Display(Name = "Tot Numele")]
        public string TotNumele => Nume + "  " + Prenume;

        public decimal CNP { get; set; }
        public string? Adresa { get; set; }
        public decimal Salariu { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataAngajare { get; set; }
        public int? StudiiID { get; set; }
        public Studii? Studii { get; set; } } //navigation property


    }

