using GlicemiasBaseDados.Model;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiasBaseDados.Map
{
    public class UsuarioMap : ClassMapping<Usuario>
    {
        public UsuarioMap()
        {
            Schema("public");
            Lazy(true);
            Id(x => x.CdUsuario, m => { m.Column("cd_usuario"); m.Generator(Generators.Sequence, gm => gm.Params(new { sequence = "usuario_cd_usuario_seq" })); });

            Property(x => x.Nome, m => m.Column("nome"));
            Property(x => x.Cpf, m => m.Column("cpf"));
            Property(x => x.DtNasc, m => m.Column("dt_nasc"));

        }
    }
}
