using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins.Configurations
{
    public class FacultyConfig : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.ToTable("Faculties", "UniversitySchema");

            builder.HasKey(f => f.FacultyId);
            builder.Property(f => f.FacultyName).IsRequired();
        }
    }
}
