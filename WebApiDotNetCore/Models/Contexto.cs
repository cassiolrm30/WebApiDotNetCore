using Microsoft.EntityFrameworkCore;
using WebApiDotNetCore.Models;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    public virtual DbSet<Livro> Livros { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebApiDotNetCore;Trusted_Connection=True;");
    //    }
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entity =>
        {
            entity.Property(e => e.Titulo).IsRequired();
        });
    }
}