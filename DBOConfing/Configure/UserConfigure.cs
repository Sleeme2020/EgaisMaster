using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.DBO;
using System.Security.Cryptography.X509Certificates;

namespace DBOConfing.Configure
{
  

    internal class UserConfigure : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name);
            builder.Property(x => x.Login).IsRequired();
            builder.HasIndex(x=> x.Login).IsUnique();
            builder.Property(x => x.Password).IsRequired();
            builder.HasData(new User()
            {
                Id = 1,
                Name = "Admin",
                Login = "Admin",
                Password = new byte[0]
            }) ;
        }
    }
}
