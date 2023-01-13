using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data2.Models
{
    public class Pessoa
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QdtFilhos { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
