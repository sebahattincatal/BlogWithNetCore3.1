namespace blog.data.context
{
    using Microsoft.EntityFrameworkCore;
    using models;

    public class blogcontext : DbContext
    {
        public blogcontext(DbContextOptions<blogcontext> options) : base(options)
        {
            public virtual DbSet<Category> Categories { get; set; }
            public virtual DbSet<Post> Posts { get; set; }
            public virtual DbSet<PostImage> PostImages { get; set; }
        }
    }
}