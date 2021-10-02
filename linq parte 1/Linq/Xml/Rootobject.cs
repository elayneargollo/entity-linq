namespace linq_parte_1
{
    public class Rootobject
    {
        public Automoveis Automoveis { get; set; }
    }

    public class Automoveis
    {
        public Fabricantes Fabricantes { get; set; }
        public Modelos Modelos { get; set; }
    }

    public class Fabricantes
    {
        public Fabricante[] Fabricante { get; set; }
    }

    public class Fabricante
    {
        public string FabricanteId { get; set; }
        public string Nome { get; set; }
    }

    public class Modelos
    {
        public Modelo[] Modelo { get; set; }
    }

    public class Modelo
    {
        public string ModeloId { get; set; }
        public string Nome { get; set; }
        public string FabricanteId { get; set; }
    }
}