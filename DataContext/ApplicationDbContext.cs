using Microsoft.EntityFrameworkCore;

namespace WebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Models.FuncionarioModel> Funcionarios { get; set; }
    }
}