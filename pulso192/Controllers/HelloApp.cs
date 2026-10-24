using Microsoft.AspNetCore.Mvc;
using pulso192.Models;

namespace pulso192.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloApp : ControllerBase
{
    [HttpGet("/")]
    public string Get()
    {
        return "Hello, Pulso192";
    }

    [HttpGet("/ocorrencias")]
    public List<Ocorrencia> getOcorrencias()
    {
        return new List<Ocorrencia>();
    }
}