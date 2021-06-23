using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PharmacieDeLaCharmeuse.Core.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


// cette classe est l'étape 2 de mise en place d'entities, c est un factory qui va creer le defautlcpntext à la place de asp.net mvc core
namespace EventSbm.Core.Data
{
    public class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<DefaultContext>
    {
        public DefaultContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                               .SetBasePath(path)
                               .AddJsonFile("appsettings.json");


            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder<DefaultContext> optionBuilder = new DbContextOptionsBuilder<DefaultContext>();
            optionBuilder.UseSqlServer(connectionString); // il faudra installer via nuget le dll correspondant a la base de donées

            return new DefaultContext(optionBuilder.Options);
        }
    }
}