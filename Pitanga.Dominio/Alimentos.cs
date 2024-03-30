using System;
namespace Pitanga.Dominio
{
	public class Alimentos
	{
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int IdAlimentosCategorias { get; set; }
        public int IdAlimentosPorcoes { get; set; }
        public int IdAlimentosBase { get; set; }
    }
}

