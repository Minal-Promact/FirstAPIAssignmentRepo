﻿using FirstAPIAssignmentRepo.Data;
using FirstAPIAssignmentRepo.Repository.Implementation;
using FirstAPIAssignmentRepo.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FirstAPIAssignmentRepo
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddScoped<EmployeeAPIDBContext>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddDbContext<EmployeeAPIDBContext>(options =>
            options.UseNpgsql(configRoot.GetConnectionString("WebApiDatabase")));
            

        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
