using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Domain.Entities
{
    public class Book
    {
        [Key]
        public int IBSN { get; set; }
        public int editoriales_id { get; set; }
        public string titulos { get; set; }
        public string sinopsis { get; set; }
        public int n_paginas { get; set; }
    }
}
