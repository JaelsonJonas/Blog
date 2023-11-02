using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Database
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options):base(options) { }

        public DbSet<Post>? Posts { get; set; }
        public DbSet<Comentario>? Comentarios { get; set; }
    }

}
