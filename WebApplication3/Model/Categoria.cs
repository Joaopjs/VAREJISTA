using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public int IdCategoria { get; set; }

        public string Titulo { get; set; }
    }
}
