using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.AspNet.Identity.DomainModel;

namespace NHibernate.AspNet.Identity
{
    public class ApplicationTenant : EntityWithTypedId<string>
    {       
        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Address { get; set; }

        public virtual string Telephone { get; set; }
    }

    public class ApplicationTenantMap : ClassMapping<ApplicationTenant>
    {
        public ApplicationTenantMap()
        {
            this.Table("ApplicationTenant");

            this.Id(x => x.Id, m => m.Generator(new UUIDHexCombGeneratorDef("D")));

            this.Property(x => x.Name);

            this.Property(x => x.Address);

            this.Property(x => x.Telephone);
        }
    }
}