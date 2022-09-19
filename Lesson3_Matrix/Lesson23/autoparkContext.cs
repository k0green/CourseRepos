using Microsoft.EntityFrameworkCore;

namespace Lesson23
{
    public partial class autoparkContext : DbContext
    {
        public autoparkContext()
        {
        }

        public autoparkContext(DbContextOptions<autoparkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<Garage> Garages { get; set; } = null!;
        public virtual DbSet<Mechanic> Mechanics { get; set; } = null!;
        public virtual DbSet<ServiceStation> ServiceStations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;database=autopark2.0;uid=root;pwd=12345678", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("audit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.HasIndex(e => e.Number, "car_number_index")
                    .IsUnique();

                entity.HasIndex(e => e.OwnerId, "owner_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Model)
                    .HasColumnType("text")
                    .HasColumnName("model");

                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .HasColumnName("number");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("owner_fk");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("drivers");

                entity.HasIndex(e => new { e.Name, e.Surname }, "driver_name_index");

                entity.HasIndex(e => e.Phone, "phone")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .HasColumnName("phone");

                entity.Property(e => e.Surname)
                    .HasMaxLength(200)
                    .HasColumnName("surname");

                entity.Property(e => e.Experience).HasColumnName("experience");

            });

            modelBuilder.Entity<Garage>(entity =>
            {
                entity.ToTable("garage");

                entity.HasIndex(e => e.CarId, "car_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CarType)
                    .HasMaxLength(30)
                    .HasColumnName("car_type");

                entity.Property(e => e.SecurityLevel).HasColumnName("security_level");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Garages)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("car_fk");
            });

            modelBuilder.Entity<Mechanic>(entity =>
            {
                entity.ToTable("mechanic");

                entity.HasIndex(e => e.Phone, "mechanic_phone_index")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .HasColumnName("phone");

                entity.Property(e => e.Specialization)
                    .HasColumnType("text")
                    .HasColumnName("specialization");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .HasColumnName("surname");

                entity.Property(e => e.Level)
                    .HasColumnName("level");
            });

            modelBuilder.Entity<ServiceStation>(entity =>
            {
                entity.ToTable("service_station");

                entity.HasIndex(e => e.MechanicId, "mechanic_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MechanicId).HasColumnName("mechanic_id");

                entity.Property(e => e.Specialization)
                    .HasColumnType("text")
                    .HasColumnName("specialization");

                entity.HasOne(d => d.Mechanic)
                    .WithMany(p => p.ServiceStations)
                    .HasForeignKey(d => d.MechanicId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("mechanic_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
