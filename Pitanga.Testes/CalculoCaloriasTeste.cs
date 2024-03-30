using System.Text.Json;
using Pitanga.Dominio.Servicos;

namespace Pitanga.Testes;

public class CalculoCaloriasTeste
{


    [Fact]
    public async Task Get_EndpointRetornaSucessoEConteudoCorreto()
    {
        // Arrange
        var servicoCarnePescados = new ServicoCarnesPescados();
        //act
        var todos = await servicoCarnePescados.ObterTodos();
        //assert
        Assert.Equal(2 ,todos.Count);

    }
}
