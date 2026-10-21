using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmBrasilApiCep.Models
{
    public class CepModel
    {
        public string? Cep { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Neighborhood { get; set; }
        public string? Street { get; set; }
        public string? Service { get; set; }

        [JsonPropertyName("ibge")]
        public Ibge? Ibge { get; set; }
    }
}