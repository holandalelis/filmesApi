using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    public void AdicionaFilme(Filme filme)
    {
        
    }

}


}