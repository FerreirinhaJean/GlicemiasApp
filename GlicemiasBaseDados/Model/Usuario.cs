using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiasBaseDados.Model
{
    public class Usuario
    {
        public virtual string Nome { get; set; }
        public virtual DateTime DtNasc { get; set; }
        public virtual int Idade { get; set; }
        public virtual string Cpf { get; set; }

        public Usuario(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }
    }
}
