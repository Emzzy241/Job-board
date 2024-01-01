using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using JobBoard.Models;
using System;


namespace JobBoard.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseRouting();

            app.UseHttpsRedirection();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller={Home}/{action=Index}/{id?}"
            );

            app.Run();

            
        }
    }
}