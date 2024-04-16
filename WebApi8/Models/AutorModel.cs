﻿using System.Text.Json.Serialization;

namespace WebApi8.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<LivrosModel> Livros { get; set; }
    }
}
