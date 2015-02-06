using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate2.Entity;

namespace NHibernate2.Mapping
{
    class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Id(x =>x.Id, k =>
            {
                k.Column("Id");
                k.Generator(Generators.Identity);
            });
            Property(x=>x.Login, k =>
            {
                k.Column("Login");
                k.Length(20);
                k.NotNullable(true);
            });
            Property(x => x.Senha, k =>
            {
                k.Column("Senha");
                k.Length(20);
                k.NotNullable(true);
            });

        }
    }
}
