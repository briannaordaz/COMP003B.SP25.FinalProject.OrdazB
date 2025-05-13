//Author: Brianna Ordaz
//Course: COMP-003B: ASP.NET Core
//Instructor: Jonathan Cruz
//Purpose: Final Project Synthesizing MVC, Web API, EF Core, and Middleware
using COMP003B.SP25.FinalProject.OrdazB.Data;
namespace COMP003B.SP25.FinalProject.OrdazB;
using COMP003B.SP25.FinalProject.OrdazB.Models;
using Microsoft.EntityFrameworkCore;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddUserSecrets<Program>();
        
        // Add services to the container.
        builder.Services.AddControllersWithViews();
        
        //Set up the database context
        builder.Services.AddDbContext<WebDevAcademyContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}