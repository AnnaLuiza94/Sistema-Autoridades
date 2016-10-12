using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using Autoridades.Models;
using Autoridades.wsDeputados;

namespace Autoridades.Controllers
{
    public class DeputadosController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet, ActionName("buscar-deputados")]
        public ActionResult BuscarDeputados()
        {
           
            var client = new DeputadosSoapClient("DeputadosSoap");
            var deputados = ConvertNode<List<Deputado>>(client.ObterDeputados()).OrderBy(x=>x.Nome).ToList();
            return View(deputados);
        }

         private static T ConvertNode<T>(XmlNode node) where T : class
        {
            MemoryStream stm = new MemoryStream();

            StreamWriter stw = new StreamWriter(stm);
            stw.Write(node.OuterXml);
            stw.Flush();

            stm.Position = 0;

            XmlSerializer ser = new XmlSerializer(typeof(T));
            T result = (ser.Deserialize(stm) as T);

            return result;
        }
    }
}