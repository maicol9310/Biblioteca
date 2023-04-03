using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Domain.Entities
{
    public class editoriales_
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Sede { get; set; }
    }
}
