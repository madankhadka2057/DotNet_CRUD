using DotNetDay3.Security;
using DotNetDay3.SolidPrinciple;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDay3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            //Dependency Injection
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddSingleton<DataSecurityProvider>();


            var app = builder.Build();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute
            (
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{ id?}"
            );

            app.Run();
        }
    }
}
