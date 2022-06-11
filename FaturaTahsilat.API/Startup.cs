using FaturaTahsilat.Core.UnitOfWorks;
using FaturaTahsilat.Data.UnitOfWorks;
using FaturaTahsilat.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using FaturaTahsilat.Core.Repositories;
using FaturaTahsilat.Data.Repositories;
using FaturaTahsilat.Core.Services;
using FaturaTahsilat.Service.Services;
using Microsoft.EntityFrameworkCore;
using FaturaTahsilat.API.Mapping;
using FaturaTahsilat.Core.Models;
using Microsoft.AspNetCore.Http;

namespace FaturaTahsilat.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUnitOfWork, UnitOfWorks>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IFaturaRepository, FaturaRepository>();
            services.AddScoped<IFaturaService, FaturaService>();
            services.AddScoped<IKullaniciRepository, KullaniciRepository>();
            services.AddScoped<IKullaniciService, KullaniciService>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server=.;database=FaturaTahsilatDB;uid=yusuf;pwd=123"));
            services.AddIdentity<Kullanici, Rol>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new PathString("https://localhost:44304/User/Login");
                x.LogoutPath = new PathString("https://localhost:44304/");
                x.ExpireTimeSpan = TimeSpan.FromDays(2);
                x.SlidingExpiration = true;
                x.Cookie = new CookieBuilder
                {
                    Name = "UserCookie",
                    SecurePolicy = CookieSecurePolicy.Always,
                    HttpOnly = true,
                    SameSite = SameSiteMode.Lax,// baðlanmada sorun olursa buraya bak
                };
                x.AccessDeniedPath = new PathString("https://localhost:44304/User/AccessDenied");
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FaturaTahsilat.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FaturaTahsilat.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
