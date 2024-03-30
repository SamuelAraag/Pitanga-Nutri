using Microsoft.AspNetCore.Mvc;
using Pitanga.Dominio;
using Pitanga.Dominio.Servicos;

namespace pitanga.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculoCaloriasController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public CalculoCaloriasController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public async Task<List<CarnesEPescados>> Get()
    {
        //pegar conexao
        var servicoCarnesPescados = new ServicoCarnesPescados();

        var logger = _logger;

        return await servicoCarnesPescados.ObterTodos();
    }
}

