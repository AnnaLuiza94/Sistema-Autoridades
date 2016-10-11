using System.Collections.Generic;
using System.Xml.Serialization;

namespace Autoridades.Models
{
    [XmlRoot(ElementName = "Deputados")]
    public class Deputados
    {
        [XmlElement(ElementName = "Deputado")]
        public List<Deputado> Deputado { get; set; }

        public bool HasNoDeputado
        {
            get { return this.Deputado.Count == 0; }
        }
    }
}