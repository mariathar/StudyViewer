using DataAccessLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudyViewer.Middleware;
using StudyViewer.Options;
using StudyViewer.Services;

namespace StudyViewer
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			//Подключение документации по апи
			services.AddSwaggerGen();

			services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

			//добавление контекста бд
			//services.AddDbContext<ApplicationDBContext>(options => options.UseSqlite(Configuration.GetConnectionString("cs")));

			//использование di
			RegisterServices(services);
			
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors(x => x
			   .AllowAnyOrigin()
			   .AllowAnyMethod()
			   .AllowAnyHeader());

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				///url.../swagger/index.html
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});

			app.UseMiddleware<JwtMiddleware>();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}

		private static void RegisterServices(IServiceCollection services)
		{
			services.AddScoped<IUserService, UserService>();
		}
	}
}
