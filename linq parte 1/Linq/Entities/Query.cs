using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_parte_1
{
    public static class Query
    {
        public static List<Musica> musicas = InstanceMock.getMusicas();
        public static List<Genero> generos = InstanceMock.getGeneros();

        public static void getQueryGenero()
        {
            var generoQuery = from genero in generos select genero;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Gênero");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome do Gênero");

            foreach(var genero in generoQuery)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            }
        }

        public static void getQueryGeneroFiltroPorNome(string nome)
        {
            var generoQuery = from genero in generos 
                              where genero.Nome.Contains(nome) 
                              select genero;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Gênero filtro nome");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome do Gênero");

            foreach(var genero in generoQuery)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            }
        }

        public static void getQueryGeneroFiltroPorId(int id)
        {
            var generoQuery = from genero in generos 
                              where genero.Id == id
                              select genero;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Gênero filtro id");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome do Gênero");

            foreach(var genero in generoQuery)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            }
        }

        public static void getQueryMusica()
        {
            var musicaQuery = from musica in musicas select musica;

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Música");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome da Música\t\t#GeneroId");

            foreach(var musica in musicaQuery)
            {
                Console.WriteLine("{0}\t{1}\t{2}", musica.Id, musica.Nome, musica.GeneroId);
            }
        }

        public static void getQueryMusicaGenero()
        {
            var musicaQueryGenero = from musica in musicas
                                    join genero in generos 
                                    on musica.GeneroId equals genero.Id
                                    select new {musica, genero};

            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de Música com seus respectivos gêneros");
            Console.WriteLine("---------------------");
            Console.WriteLine("#Id\t#Nome da Música\t\t#Genero");

            foreach(var queryResult in musicaQueryGenero)
            {
                Console.WriteLine("{0}\t{1}\t{2}", queryResult.musica.Id, queryResult.musica.Nome, queryResult.genero.Nome);
            }
        }
    }
}