using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ASMC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASMC5.Services;

namespace ASMC5
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
            services.AddDbContext<DataContext>(op =>
              op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IMoan, MonAnSvc>();

            services.AddTransient<IMahoaHelper,MaHoaSvc>();

            services.AddTransient<INguoiDung, NguoiDungSvc>();

            services.AddTransient<IKhachHang, KhachHangSvc>();

            services.AddTransient<ISendEmail,SendEmailSvc>();

            services.AddTransient<IDonHang, DonHangSvc>();

            services.AddTransient<IDonHangCT, DonHangChiTietSvc>();

            services.AddTransient<ICart, CartSvc>();

            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30); });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=HomePage}/{action=Index}/{id?}");
            });
        }
    }
}
