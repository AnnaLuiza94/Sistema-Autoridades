using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autoridades.Models
{
    [Table("Phone")]
    public class Telefone
    {
        public Telefone()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Tipo de órgão")]
        public string PhoneNumber { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Sub tipo de órgão")]
        public string PhoneNumberBranch { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Sub tipo de órgão")]
        public string PhoneNumberType { get; set; }

        public virtual Social Social { get; set; }
    }
}