using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profissional.Models
{


    public class ProfissionalModel
    {
        public ProfissionalModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
   
    }
}

