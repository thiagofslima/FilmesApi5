﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi5.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 240, ErrorMessage = "A duração deve ter no mínimo 1 e no máxixo 240 minutos")]
        public int Duracao { get; set; }
    }
}
