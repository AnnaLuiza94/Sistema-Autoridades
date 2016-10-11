using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Autoridades.Models
{

    public class AplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string WifeOrHusbandName { get; set; }
        public string WifeOrHusbandBirthDate { get; set; }
        public bool HaveChildren { get; set; }
        
        public string Observations { get; set; }
        public string AccountCreationDate { get; set; }

        public virtual ICollection<Contatos> Contacts { get; set; }
        public virtual ICollection<Filhos> Filhos { get; set; }
    }
}