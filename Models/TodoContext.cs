using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public TodoContext(DbContextOptions<TodoContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }
        
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var consstr = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(consstr);
        }
    }
}