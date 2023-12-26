using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KiemTra.Models
{
    public partial class QLSachContext : DbContext
    {
        public QLSachContext()
        {
        }

        public QLSachContext(DbContextOptions<QLSachContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-UG4NT4G\\SQLEXPRESS;Initial Catalog=QLSach;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__Sach__B235742DFE70BC1F");

                entity.ToTable("Sach");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaTg)
                    .HasMaxLength(10)
                    .HasColumnName("MaTG")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSach)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaTgNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaTg)
                    .HasConstraintName("fk_S_TG");
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.MaTg)
                    .HasName("PK__TacGia__27250074CBE88AA9");

                entity.Property(e => e.MaTg)
                    .HasMaxLength(10)
                    .HasColumnName("MaTG")
                    .IsFixedLength(true);

                entity.Property(e => e.TenTacGia)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
