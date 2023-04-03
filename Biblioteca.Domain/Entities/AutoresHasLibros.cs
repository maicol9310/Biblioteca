using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Domain.Entities
{
    public class AutoresHasLibros
    {
        [Key]
        public int Id { get; set; }
        public int AutoresId { get; set; }
        public int BookIBSN { get; set; }
    }
}
