namespace GameUniProject
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Repositories.ExtraRepository;
    using Repositories.GameExtraRepository;
    using Repositories.GameRepository;
    using Repositories.PublisherRepository;
    using System;
    using System.Windows.Forms;

    static class StartUp
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-XD;Database=Games;Trusted_Connection=True");
            });

            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
            services.AddScoped<IGameExtraRepository, GameExtraRepository>();

            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
