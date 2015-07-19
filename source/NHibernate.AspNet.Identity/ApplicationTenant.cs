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
        //public ApplicationTenant()
        //{
        //   this.Users = new List<IdentityUser>();            
        //}

        public virtual string Id { get; set; }

        public virtual string Name { get; set; }

        //public virtual IList<IdentityUser> Users { get; set; }
    }

    public class ApplicationTenantMap : ClassMapping<ApplicationTenant>
    {
        public ApplicationTenantMap()
        {
            this.Table("ApplicationTenant");

            this.Id(x => x.Id, m => m.Generator(new UUIDHexCombGeneratorDef("D")));

            this.Property(x => x.Name);

            //this.Bag(x => x.Users, map =>
            //{
            //    map.Key(k =>
            //    {
            //        k.Column("TenantId");
            //        k.Update(false); // to prevent extra update afer insert
            //    });
            //    map.Cascade(Cascade.All | Cascade.DeleteOrphans);
            //}, rel =>
            //{
            //    rel.OneToMany();
            //});
        }
    }
}