using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Data
{
    public class EscuelaDBMVCContext : DbContext
    {
        public EscuelaDBMVCContext(DbContextOptions<EscuelaDBMVCContext> options) : base(options) { }

        public DbSet<Aula> Aulas { get; set; }
    }
}
