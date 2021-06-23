using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using testIdentityEncore.Areas.Identity.Data;
using testIdentityEncore.Data;

[assembly: HostingStartup(typeof(testIdentityEncore.Areas.Identity.IdentityHostingStartup))]
namespace testIdentityEncore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<testIdentityEncoreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("testIdentityEncoreContextConnection")));

                services.AddDefaultIdentity<testIdentityEncoreUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<testIdentityEncoreContext>();
            });
        }
    }
}