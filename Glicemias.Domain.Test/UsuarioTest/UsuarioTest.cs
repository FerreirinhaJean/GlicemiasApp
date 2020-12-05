using GlicemiasBaseDados.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glicemias.Domain.Test.UsuarioTest
{
    [TestFixture]

    public class UsuarioTest
    {

        [Test]
        public void CriarUsuario()
        {
            string Nome = "Jean Gabriel Ferreira";
            int Idade = 21;
            string Cpf = "029.002.050-69";

            var usuario = new Usuario(Nome, Idade, Cpf);

            Assert.That(usuario.Nome, Is.EqualTo(Nome));
            Assert.That(usuario.Idade, Is.EqualTo(Idade));
            Assert.That(usuario.Cpf, Is.EqualTo(Cpf));


        }


    }
}
