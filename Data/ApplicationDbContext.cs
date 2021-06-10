namespace Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<GameExtra> GameExtras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Server = DESKTOP-XD
            //Database = Games
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-XD;Database=Games;Trusted_Connection=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }


    }
}
