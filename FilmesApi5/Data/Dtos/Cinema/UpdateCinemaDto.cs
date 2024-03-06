﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi5.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
