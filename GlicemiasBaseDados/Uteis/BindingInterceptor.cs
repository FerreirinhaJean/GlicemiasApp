using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlicemiasBaseDados.Uteis
{
    public class BindingInterceptor : EmptyInterceptor
    {
        public ISessionFactory SessionFactory { set; get; }

        public override object Instantiate(string clazz, EntityMode entityMode, object id)
        {
            if (entityMode == EntityMode.Poco)
            {
                var type = Type.GetType(clazz);

                if (type != null)
                {
                    var instance = NotificaBinding.Create(type);
                    SessionFactory.GetClassMetadata(clazz).SetIdentifier(instance, id, entityMode);
                    return instance;
                }
            }

            return base.Instantiate(clazz, entityMode, id);
        }

        public override string GetEntityName(object entity)
        {
            var type = entity.GetType();

            if (type.FullName.StartsWith("Castle.Proxies") && type.FullName.EndsWith("Proxy"))
            {
                return type.BaseType.FullName;
            }

            return base.GetEntityName(entity);
        }
    }
}
