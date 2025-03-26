using System.ComponentModel.DataAnnotations;

namespace L01P022022AJ650.Models
{
    public class facultades
    {
        [Key]
        public int Id { get; set; }
        public string? Facultad { get; set; }
    }
}
