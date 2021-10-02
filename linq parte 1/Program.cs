using System.CodeDom.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Query.getQueryMusica();
            Query.getQueryGenero();
            Query.getQueryMusicaGenero();
            Query.getQueryGeneroFiltroPorNome(nome: "Rock");        
            Query.getQueryGeneroFiltroPorId(id: 1);  

            Arquivo.getFabricanteFromQueryArquivoXml();
            Arquivo.getModelosFromQueryArquivoXml();
            Arquivo.getModelosFabricateFromQueryArquivoXml();
        }
    }
}
