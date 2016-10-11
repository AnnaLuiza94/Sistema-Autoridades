using System.Collections.Generic;
using System.Xml.Serialization;

namespace Autoridades.Models
{
    namespace Autoridades.Models
    {
        [XmlRoot(ElementName = "comissoes")]
        public class Comissoes
        {
            [XmlElement(ElementName = "titular")]
            public string Titular { get; set; }

            [XmlElement(ElementName = "suplente")]
            public string Suplente { get; set; }
        }
    }
}