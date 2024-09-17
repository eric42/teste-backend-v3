using System.Xml.Linq;

namespace TheatricalPlayersRefactoringKata
{
    public class XmlGenerator
    {
        public static XElement GerarXml(List<Peca> pecas)
        {
            XElement xml = new XElement("Performances",
                from p in pecas
                select new XElement("Peca",
                            new XAttribute("Titulo", p.Titulo),
                            new XAttribute("Linhas", p.Linhas),
                            new XAttribute("Publico", p.Publico),
                            new XAttribute("Valor", p.CalcularValor().ToString("F2")),
                            new XAttribute("Creditos", p.CalcularCreditos())
                        )
                );

            return xml;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de lista de peças (como no exemplo anterior)
        // ...

        XElement xml = XmlGenerator.GerarXml(pecas);
        Console.WriteLine(xml.ToString());
    }
}

