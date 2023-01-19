using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Models
{
    public class Studii
    {
        public int ID { get; set; }
        public int Gimnaziale { get; set; }
        public int Liceale { get; set; }
        public int Superioare { get; set; }
        public IEnumerable<Angajat>? Angajati { get; internal set; }
        public object CNP { get; internal set; }
    }

}

