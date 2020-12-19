using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApi.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public string Nomereal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
