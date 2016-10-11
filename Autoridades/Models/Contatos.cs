using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autoridades.Models
{
    [Table("Contacts")]
    public class Contatos
    {
        public Contatos()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public virtual AplicationUser User { get; set; }
    }
}