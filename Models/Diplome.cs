using System.Reflection.Metadata;

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Models
{
    public class Diplome<T>
    {
        public int ID { get; set; }
        public string? Nume { get; set; }
        public string? DataAbsolvire { get; set; }
        public string? Domeniu { get; set; }
        public string? Specializare { get; set; }



    }
}