using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
