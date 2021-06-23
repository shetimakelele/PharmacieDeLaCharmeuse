using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PharmacieDeLaCharmeuse.Core.Data;
using PharmacieDeLaCharmeuse.Core.Data.Migrations;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using PharmacieDeLaCharmeuse.Core.Data.Repository;
using System;

namespace PharmacieDelaCharmeuse
{
    public class Startup
    {
        public Startup(Microsoft.Extensions.Hosting.IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                                             .SetBasePath(env.ContentRootPath)
                                             .AddJsonFile("appsettings.json",
                                                          optional:false,
                                                          reloadOnChange: true)
                                             .AddEnvironmentVariables();

            if(env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IProduitRepository, ProduitRepository>(); 
            services.AddScoped<ICategorieProduitRepository, CategorieProduitRepository>();
            services.AddScoped<IAstuceRepository, AstuceRepository>();
            services.AddScoped<ICommandeRepository, CommandeRepository>();
            services.AddScoped<ITestProduitRepository, TestProduitRepository>();

            // api facebook
            services.AddAuthentication()
                    .AddFacebook(Options =>
                    {
                        Options.AppId = "Api:Facebook:AppId";
                        Options.AppSecret = "Api:Facebook:AppSecret";

                    });
            string ConnectionString = this.Configuration.GetConnectionString("DefaultContext");

            // definit le context pour tout le projet web
            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(ConnectionString), ServiceLifetime.Scoped);// scoped pour réinstancier a chaque demande

            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSession();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
