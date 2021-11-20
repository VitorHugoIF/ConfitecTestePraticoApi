using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confitec.TestePratico.Domain.Enums;

namespace Confitec.TestePratico.Domain.Entities
{
    public class User : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public SchoolingEnum Escolaridade { get; set; }
    }
}
