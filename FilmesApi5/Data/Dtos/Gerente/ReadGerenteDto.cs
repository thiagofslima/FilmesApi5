using FilmesApi5.Models;
using System.Collections.Generic;

namespace FilmesApi5.Data.Dtos
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinemas { get; set; }
    }
}
