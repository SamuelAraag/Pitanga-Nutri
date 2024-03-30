using Pitanga.Dominio.Servicos;

namespace Pitanga.Testes;

public class CalculoCaloriasTeste
{


    [Fact]
    public async Task ao_obter_tabela_carnes_e_pescas_retornar_2_itens()
    {
        // Arrange
        var servicoCarnePescados = new ServicoCarnesPescados();
        //act
        var todos = await servicoCarnePescados.ObterTodos();
        //assert
        Assert.Equal(597, todos.Count);
    }

    [Theory]
    [InlineData("arroz", 78)]
    [InlineData("a", 1)]
    [InlineData("ab", 3)]
    [InlineData("abc", 6)]
    [InlineData("z", 26)]
    [InlineData("y", 25)]
    [InlineData("zy", 51)]
    public void teste(string palavra, int valorEsperado)
    {
        var letrasList = new List<string> {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        //separa a palavra em letras, pra cada letra pega o valor e soma
        var letrasPalavra = palavra.ToCharArray();

        var somaDosValores = 0;
        for (int i = 0; i < letrasPalavra.Length; i++)
        {
            var letra1 = letrasPalavra[i];

            var contemValor = letrasList.IndexOf(letra1.ToString());
            if (contemValor != -1)
            {
                somaDosValores += contemValor + 1;
            }
        }

        Assert.Equal(valorEsperado, somaDosValores);
    }
}
