﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi5.Data.Dtos
{
    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
