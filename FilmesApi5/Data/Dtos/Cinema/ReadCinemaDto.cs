using FilmesApi5.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi5.Data.Dtos
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
