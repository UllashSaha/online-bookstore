using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Areas.Identity.Data;
using MvcMovie.Data;

[assembly: HostingStartup(typeof(MvcMovie.Areas.Identity.IdentityHostingStartup))]
namespace MvcMovie.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcBookContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MvcBookContext")));

                services.AddDefaultIdentity<MvcBookUser>(options =>
                { options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;


                }
                

              

                )


                    .AddEntityFrameworkStores<MvcBookContext>();
            });
        }
    }
}