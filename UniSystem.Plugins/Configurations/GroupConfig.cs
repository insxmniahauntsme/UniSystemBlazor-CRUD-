using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniSystem.Plugins.Configurations
{
    public class GroupConfig : IEntityTypeConfiguration<Core.Entities.Group>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Group> builder)
        {
            builder.ToTable("Groups", "UniversitySchema");

            builder.HasKey(g => g.GroupId);
            builder.Property(g => g.GroupName).IsRequired();
            builder.Property(g => g.Faculty).IsRequired();



        }
    }
}
