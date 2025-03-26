using System.ComponentModel.DataAnnotations;

namespace L01P022022AJ650.Models
{
    public class alumnos
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Dui { get; set; }
        public int Estado { get; set; }
    }
}
