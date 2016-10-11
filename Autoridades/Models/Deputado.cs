using System.Xml.Serialization;
using Autoridades.Models.Autoridades.Models;

namespace Autoridades.Models
{
    [XmlRoot(ElementName = "deputado")]
    public class Deputado
    {
        [XmlElement(ElementName = "ideCadastro")]
        public string IdeCadastro { get; set; }
        [XmlElement(ElementName = "codOrcamento")]
        public string CodOrcamento { get; set; }
        [XmlElement(ElementName = "condicao")]
        public string Condicao { get; set; }
        [XmlElement(ElementName = "matricula")]
        public string Matricula { get; set; }
        [XmlElement(ElementName = "idParlamentar")]
        public string IdParlamentar { get; set; }
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "nomeParlamentar")]
        public string NomeParlamentar { get; set; }
        [XmlElement(ElementName = "urlFoto")]
        public string UrlFoto { get; set; }
        [XmlElement(ElementName = "sexo")]
        public string Sexo { get; set; }
        [XmlElement(ElementName = "uf")]
        public string Uf { get; set; }
        [XmlElement(ElementName = "partido")]
        public string Partido { get; set; }
        [XmlElement(ElementName = "gabinete")]
        public string Gabinete { get; set; }
        [XmlElement(ElementName = "anexo")]
        public string Anexo { get; set; }
        [XmlElement(ElementName = "fone")]
        public string Fone { get; set; }
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "comissoes")]
        public Comissoes Comissoes { get; set; }
    }


}
