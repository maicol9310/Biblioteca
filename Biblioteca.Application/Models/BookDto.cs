using Biblioteca.Application.Mappings;
using Biblioteca.Domain.Entities;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Application.Models
{
    public class BookDto : IMapFrom<Book>
    {
        [Key]
        public int IBSN { get; set; }

        [Required()]
        public int editoriales_id { get; set; }

        [Required()]
        public string titulos { get; set; }

        [Required()]
        public string sinopsis { get; set; }

        [Required()]
        public int n_paginas { get; set; }
    }
}
