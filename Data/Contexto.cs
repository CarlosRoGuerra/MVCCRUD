using Microsoft.EntityFrameworkCore;
using ProjetoMVC2024.Models;

namespace ProjetoMVC2024.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options) 
        {}
        public DbSet<Formulario> Formulario { get; set; }
    }
}
