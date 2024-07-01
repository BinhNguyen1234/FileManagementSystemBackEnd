
using FileManagementSystemBE.Middleware;
using FileManagementSystemBE.Model;
using Microsoft.EntityFrameworkCore;

namespace FileManagementSystemBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ConfigureServices(builder.Services, builder);

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            ConfigureApplication(app);
            app.Run();
        }
        private static void ConfigureServices(IServiceCollection services, WebApplicationBuilder builder)
        {
            string? connectionString = builder.Configuration.GetConnectionString("pgsql");
            services.AddDbContext<MockupContext>(builderOption =>
               {
                   builderOption.UseNpgsql(connectionString);
               });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        private static void ConfigureApplication(WebApplication app)
        {
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}
