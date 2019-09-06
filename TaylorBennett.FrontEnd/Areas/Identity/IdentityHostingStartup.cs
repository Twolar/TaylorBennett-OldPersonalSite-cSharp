using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaylorBennett.FrontEnd;
using TaylorBennett.FrontEnd.Data;

[assembly: HostingStartup(typeof(TaylorBennett.FrontEnd.Areas.Identity.IdentityHostingStartup))]
namespace TaylorBennett.FrontEnd.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityDbContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("IdentityDbContextConnection")));

                services.AddDefaultIdentity<User>( opt =>
                {
                    opt.Password.RequireDigit = false;
                    opt.Password.RequiredLength = 1;
                    opt.Password.RequiredUniqueChars = 0;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                })
                    .AddDefaultUI(UIFramework.Bootstrap4)
                    .AddEntityFrameworkStores<IdentityDbContext>()
                    .AddClaimsPrincipalFactory<ClaimsPrincipalFactory>();
            });
        }
    }
}