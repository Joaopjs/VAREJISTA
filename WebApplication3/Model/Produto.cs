using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class Produto
    {
        [Required]
        [Range(1, 3)]
        public int IdCategoria { get; set; }
        [Required]
        [MaxLength(60)]
        public string NomeProduto { get; set; }
        [Required]
        [Range(1, 30000)]
        public int Preco { get; set; }
        [MaxLength(150)]
        [Required]
        public string Descricao { get; set; }

    }
}
