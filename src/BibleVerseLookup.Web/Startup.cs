using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BibleVerseLookup.Web
{
	public class Startup
	{
		private IHostingEnvironment CurrentEnvironment { get; set; }

		public Startup(IHostingEnvironment env, IConfiguration configuration)
		{
			CurrentEnvironment = env;
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => false;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddMvc()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
				.AddRazorPagesOptions(options =>
				{
					options.Conventions.AddPageRoute(Pages.Anchors.Home.Index, "");
				}); 
		}


		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc();
		}
	}
}
