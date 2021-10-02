using System;
using System.Collections.Generic;

namespace linq_parte_1
{
    public static class InstanceMock
    {
        public static List<Genero> getGeneros()
        {
            return new List<Genero>
            {
                new Genero { Id = 1, Nome = "Rock"},
                new Genero { Id = 2, Nome =  "Reggae"},
                new Genero { Id = 3, Nome =  "Rock Progressivo"},
                new Genero { Id = 4, Nome =  "Punk"},
                new Genero { Id = 5, Nome =  "Clássica"}
            };
        }       

        public static List<Musica> getMusicas()
        {
            return new List<Musica>
            {
                new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
                new Musica { Id = 2, Nome = "I Shoot The Sheriff", GeneroId = 2},
                new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 5},
            };
        }
    }
}