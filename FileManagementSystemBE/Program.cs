
namespace FileManagementSystemBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ConfigureServices(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            ConfigureApplication(app);
            app.Run();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            {
                services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();
            }
        }
        private static void ConfigureApplication(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
        }
    }
}
