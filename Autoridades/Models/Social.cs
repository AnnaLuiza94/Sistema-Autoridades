using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Autoridades.Models
{
    [Table("Social")]
    public class Social : IdentityUser
    {
        // Social 

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Tipo de órgão")]
        public string OrganType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Sub tipo de órgão")]
        public string OrganSubType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Departamento")]
        public string Departament { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Sub departamento")]
        public string SubDepartament { get; set; }

        [Display(Name = "Foto")]
        public string Photo { get; set; }

        [MaxLength(128, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [Display(Name = "Cargo")]
        public string Responsability { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Fornceça um nome para o Título")]
        [Display(Name = "Tratamento")]
        public string Treatment { get; set; }

        [Display(Name = "Partido")]
        public string Party { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Posto/Grad")]
        public string Post { get; set; }

        [Display(Name = "Empresa/Órgão")]
        public string CompanyName { get; set; }

        // Endereço

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "UF")]
        public string CityInitials { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Município")]
        public string City { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        // Fim endereço

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "OPM")]
        public string Opm { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Site")]
        public string Site { get; set; }

        [MaxLength(10240, ErrorMessage = "Tamanho máximo {0} excedido")]
        [Display(Name = "Email")]
        public string CorporativeEmail { get; set; }

        // Telefones
        public virtual ICollection<Telefone> Phones { get; set; }

        
    }
}