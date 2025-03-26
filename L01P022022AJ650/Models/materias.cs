using System.ComponentModel.DataAnnotations;

namespace L01P022022AJ650.Models
{
    public class materias
    {
        [Key]
        public int Id { get; set; }
        public string Materia { get; set; }
        public int Unidades_Valorativas { get; set; }
        public char Estado { get; set; }
    }
}
