using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A._8_DesignPatternsAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            XmlSerializer serializer = new XmlSerializer(cliente.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, cliente);
            String xml = writer.ToString();


            Cliente cliente2 = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            GeradorDeXml gerador = new GeradorDeXml();
            String xml2 = gerador.GeraXml(cliente);
        }
    }
}
