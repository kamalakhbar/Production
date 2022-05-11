using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
//using Northwind.Contracts;
//using Northwind.LoggerService;
//using Northwind.Entities.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using Northwind.Repository;
//using Northwind.Contracts;
//using Northwind.Entities.Models;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
namespace ProductionWebApi.Extension
{
    public static class ServiceEntension
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            }
            );
        // jika tdk pake CORS maka langsung di resterict... maka dari itu harus di allow /izin kan dulu slama development
        // origin = utk memanggil domain, dll
        //add IIS configure options deploy to ISS
        public static void ConfigureIISIntergration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            }
            );
    }
}
