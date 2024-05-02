using ActivitySystem.BLL.Interface;
using ActivitySystem.BLL.Repository;
using ActivitySystem.DAL.Context;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;

namespace ActivitySystem.PL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();


        //connection 
        builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

        //dependency injection
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


        //sources 
        builder.Services.AddLocalization(options => options.ResourcesPath = "Resources"); builder.Services.AddControllersWithViews().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

        builder.Services.Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new[] { "en", "ar" };
            options.SetDefaultCulture(supportedCultures[1])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);
            var questStringCultureProvider = options.RequestCultureProviders[0];
            options.RequestCultureProviders.RemoveAt(0);
            options.RequestCultureProviders.Insert(1, questStringCultureProvider);
        });

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddSession(option =>
        {

        });

        builder.Services.Configure<FormOptions>(options =>
        {
            options.MultipartBodyLengthLimit = 1024 * 1024 * 10; // 10 MB
        });

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
        app.UseRequestLocalization();
        app.UseRouting();

        app.UseAuthorization();
        app.UseSession();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
