using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Genero { get; set; }
    [Required]
    [Range(70,600)]
    public int Duracao { get; set; }
}