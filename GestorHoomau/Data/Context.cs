using GestorHoomau.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorHoomau.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options) 
        {

        }

        public DbSet<Produto> Produto { get; set; }

    }
}
