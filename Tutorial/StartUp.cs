using Microsoft.EntityFrameworkCore;
using Tutorial.DataAccess;

namespace Tutorial
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options=> options.EnableEndpointRouting=false);
            // Регистрация DbContext и настройка строки подключения
            services.AddDbContext<BookDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });

            // Регистрация ваших служб
            //services.AddScoped<IUserServices, UserServices>();
            //services.AddScoped<IOrderServices, OrderServices>();

            // Регистрация контроллеров
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers(); // Настройка маршрутизации контроллеров
            //});
        }
    }
}
