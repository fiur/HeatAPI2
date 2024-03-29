using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using HeatAPI.DataContext;

namespace React.Sample.Webpack.CoreMvc
{
	public class Startup
	{
		readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<VarmedataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VarmeDataContext")));

			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
								  builder =>
								  {
									  builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
								  });
			});
			services.AddSwaggerDocument();

			services.AddMvcCore().AddApiExplorer();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostEnvironment env)
		{
			app.UseCors(MyAllowSpecificOrigins);
			if (env.IsDevelopment())
			{
					app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			app.UseRouting();
			app.UseOpenApi(); // serve documents (same as app.UseSwagger())
			app.UseSwaggerUi3(); // serve Swagger UI

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute("default", "{path?}", new { controller = "Home", action = "Index" });
				endpoints.MapControllerRoute("api", "api/tude/{n}", new { controller = "get", action = "GetTude" });
			});

		}
	}
}
