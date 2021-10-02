namespace linq_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinQ to Object
            Query.getQueryMusica();
            Query.getQueryGenero();
            Query.getQueryMusicaGenero();
            Query.getQueryGeneroFiltroPorNome(nome: "Rock");        
            Query.getQueryGeneroFiltroPorId(id: 1);  

            // LinQ to XML
            Arquivo.getFabricanteFromQueryArquivoXml();
            Arquivo.getModelosFromQueryArquivoXml();
            Arquivo.getModelosFabricateFromQueryArquivoXml();
            Arquivo.XmlConvertRootobjectJoin();
        }
    }
}
