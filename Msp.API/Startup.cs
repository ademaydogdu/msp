using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Msp.Service.Mapping;
using Newtonsoft.Json;

namespace Msp.API
{
    //public class Startup
    //{
    //    public Startup(IHostingEnvironment env)
    //    {
    //        var builder = new ConfigurationBuilder()
    //               .SetBasePath(env.ContentRootPath)
    //               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    //               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

    //        Configuration = builder.Build();


    //        //AutoMapper.Mapper.Initialize(x => Mappings.Configure(x));
    //    }

    //    public IConfiguration Configuration { get; }

    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value);


    //        services.Configure<GzipCompressionProviderOptions>(options =>
    //        {
    //            options.Level = CompressionLevel.Fastest;
    //        });

    //        services.AddResponseCompression(options =>
    //        {
    //            IEnumerable<string> MimeTypes = new[]
    //              {
    //                     "text/plain",
    //                     "text/html",
    //                     "text/css",
    //                     "font/woff2",
    //                     "application/javascript",
    //                     "image/x-icon",
    //                     "image/png",
    //                     "application/json",
    //                     "application/json; charset=utf-8"
    //                 };

    //            options.Providers.Add<GzipCompressionProvider>();
    //            options.MimeTypes = MimeTypes;
    //        });

    //        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    //          .AddJwtBearer(option =>
    //          {
    //              option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    //              {
    //                  ValidateIssuerSigningKey = true,
    //                  IssuerSigningKey = new SymmetricSecurityKey(key),
    //                  ValidateIssuer = false,
    //                  ValidateAudience = false
    //              };
    //          });

    //        services.AddMvc().AddJsonOptions(options =>
    //        {
    //            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    //        }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    //    }

    //    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    //    {
    //        if (env.IsDevelopment())
    //        {
    //            app.UseDeveloperExceptionPage();
    //        }
    //        app.UseResponseCompression();
    //        app.UseAuthentication();
    //        app.UseMvc();
    //    }
    //}
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AutoMapper.Mapper.Initialize(x => Mappings.Configure(x));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));


            services.Configure<GzipCompressionProviderOptions>(options =>
          options.Level = System.IO.Compression.CompressionLevel.Fastest);

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                                         {

                    "text/plain",
                    "text/css",
                    "application/javascript",
                    "text/html",
                    "application/xml",
                    "text/xml",
                    "text/json",
                    "application/json",
                    "application/json; charset=utf-8"
                            }); ;
                options.Providers.Add<GzipCompressionProvider>();
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseResponseCompression();
            app.UseMvc();

        }
    }

}
