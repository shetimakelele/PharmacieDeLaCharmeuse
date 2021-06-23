using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacieDelaCharmeuse.Areas.Identity.Data;
using PharmacieDelaCharmeuse.Data;

[assembly: HostingStartup(typeof(PharmacieDelaCharmeuse.Areas.Identity.IdentityHostingStartup))]
namespace PharmacieDelaCharmeuse.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PharmacieDelaCharmeuseContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PharmacieDelaCharmeuseContextConnection")));

                services.AddDefaultIdentity<PharmacieDelaCharmeuseUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PharmacieDelaCharmeuseContext>();
            });
        }
    }
}