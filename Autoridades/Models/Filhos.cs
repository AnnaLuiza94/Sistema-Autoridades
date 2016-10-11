using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Autoridades.Models
{
    [Table("Filhos")]
    public class Filhos
    {
        public Filhos()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Aniversário")]
        public string BirthDate { get; set; }

        public virtual AplicationUser User { get; set; }
    }
}