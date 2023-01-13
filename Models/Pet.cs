using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data2.Models
{
    public class Pet
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }


        public int ? PessoaId { get; set; }
        public Pessoa pessoa { get; set; }


        [Required]
        public bool Adotado { get; set; }
    }
}
