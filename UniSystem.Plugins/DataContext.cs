using Microsoft.EntityFrameworkCore;
using UniSystem.Plugins.Configurations;
using UniSystem.Core.Entities;

namespace UniSystem.Plugins
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=localhost;Database=University;TrustServerCertificate=true;Trusted_Connection=true;";
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public DataContext() { }

        // this constructor is used, when registering DbContext as a service
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionString,
                    optionsBuilder => optionsBuilder.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FacultyConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }
    }
}
    