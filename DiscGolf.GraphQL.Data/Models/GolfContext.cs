using Microsoft.EntityFrameworkCore;

namespace DiscGolf.GraphQL.Data.Models
{
    public partial class GolfContext : DbContext
    {
        private readonly string _connectionString;

        public GolfContext(DbContextOptions<GolfContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Hole> Hole { get; set; }
        public virtual DbSet<HoleResult> HoleResult { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Round> Round { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Hole>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Hole)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hole_Course");
            });

            modelBuilder.Entity<HoleResult>(entity =>
            {
                entity.HasOne(d => d.Hole)
                    .WithMany(p => p.HoleResult)
                    .HasForeignKey(d => d.HoleId)
                    .HasConstraintName("FK_HoleResult_Hole");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.HoleResult)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_HoleResult_Person");

                entity.HasOne(d => d.Round)
                    .WithMany(p => p.HoleResult)
                    .HasForeignKey(d => d.RoundId)
                    .HasConstraintName("FK_HoleResult_Round");
            });

            modelBuilder.Entity<Round>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Round)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Round_Course");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
