using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApi.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta identidadeSecreta { get; set; }
        public IEnumerable<HeroiBatalha> HeroisBatalhas { get; set; }
        public IEnumerable<Arma> Armas { get; set; }
    }
}
