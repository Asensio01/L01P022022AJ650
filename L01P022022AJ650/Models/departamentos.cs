using System.ComponentModel.DataAnnotations;

namespace L01P022022AJ650.Models
{
    public class departamentos
    {
        [Key]
        public int Id { get; set; }
        public string? Departamento { get; set; }
    }
}
