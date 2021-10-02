using System.Reflection;
using System.Xml.Linq;
using System.Linq;
using System.CodeDom.Compiler;
using System;
using System.Collections.Generic;

namespace linq_parte_1
{
    public static class Arquivo
    {
        public static XElement root = XElement.Load(@"File\Automoveis.xml");

        public static void getFabricanteFromQueryArquivoXml()
        {
            var queryXmlFabricantes = from fabricante in root.Element("Fabricantes").Elements("Fabricante")
                                      select fabricante;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Fabricantes do arquivo Xml");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome do fabricante");

            foreach (var fabricante in queryXmlFabricantes)
            {
                Console.WriteLine("{0}\t{1}", fabricante.Element("FabricanteId").Value, fabricante.Element("Nome").Value);
            }
        }

        public static void getModelosFromQueryArquivoXml()
        {
            var queryXmlModelos = from modelo in root.Element("Modelos").Elements("Modelo")
                                  select modelo;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Modelos do arquivo Xml");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome do Modelo\t\tFabricanteId");

            foreach (var modelo in queryXmlModelos)
            {
                Console.WriteLine("{0}\t{1}\t\t\t{2}", modelo.Element("ModeloId").Value, modelo.Element("Nome").Value, modelo.Element("FabricanteId").Value);
            }
        }

        public static void getModelosFabricateFromQueryArquivoXml()
        {
            var queryXmlModelos = from modelo in root.Element("Modelos").Elements("Modelo")
                                  join fabricante in root.Element("Fabricantes").Elements("Fabricante")
                                  on modelo.Element("FabricanteId").Value equals fabricante.Element("FabricanteId").Value
                                  select new 
                                  {
                                    Modelo = modelo.Element("Nome").Value,
                                    Fabricante = fabricante.Element("Nome").Value
                                  };
                             

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Modelos com seus respectivos fabricantes do arquivo Xml");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Nome do Modelos\t#Nome do Fabricante");

            foreach (var modeloEfabricante in queryXmlModelos)
            {
                Console.WriteLine("{0}\t\t\t{1}", modeloEfabricante.Modelo, modeloEfabricante.Fabricante);
            }
        }
    }
}