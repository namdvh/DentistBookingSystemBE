using BokkingDentist.Constant;
using DentisBooking.Data.DataContext;
using DentisBooking.Data.Entities;
using DentistBooking.Application.System.Clinics;
using DentistBooking.Application.System.Dentists;
using DentistBooking.Application.System.Users;
using DentistBooking.ViewModels.System.Dentists;
using DentistBooking.ViewModels.System.Users;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace DentisBooking.Api
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Users/refresh/";
                    options.AccessDeniedPath = "/Users/refresh/";
                });
            //Add AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //DBcontext
            services.AddDbContext<DentistDBContext>(options => options.
            UseSqlServer(Configuration.GetConnectionString(SystemsConstant.MainConnectionString)));


            services.AddIdentity<User, Role>().AddEntityFrameworkStores<DentistDBContext>().AddDefaultTokenProviders();

            //Delcare DI
            services.AddScoped<UserManager<User>, UserManager<User>>();
            services.AddScoped<SignInManager<User>, SignInManager<User>>();
            services.AddScoped<RoleManager<Role>, RoleManager<Role>>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDentistService, DentistService>();
            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<IValidator<RegisterRequest>,RegisterRequestValidator>();
            services.AddScoped<IValidator<AddDentistRequest>,AddDentistRequestValidator>();
            //services.AddScoped<IAuthorizationMiddlewareResultHandler, AuthorizeMiddleWare>();

            services.AddCors(o =>
            {
                o.AddPolicy("MyPolicy", builder =>
            builder.WithOrigins("https://localhost:4000")
                       .AllowAnyHeader()
                       .AllowCredentials());
            });
            services.AddScoped<IClinicService, ClinicService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DentisBooking.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
            });
            string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            string signingKey = Configuration.GetValue<string>("Tokens:Key");
            byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = System.TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
                };
                options.Events = new JwtBearerEvents
                {
                    OnChallenge = async (context) =>
                    {
                        Console.WriteLine("Printing in the delegate OnChallenge");

                        context.HandleResponse();

                        if (context.AuthenticateFailure != null)
                        {
                            DentistResponse response = new();
                            response.Message = "Token Validation Has Failed. Request Access Denied";
                            response.Code = "900";
                            if (!context.Response.HasStarted)
                            {
                                string result;
                                context.Response.StatusCode = StatusCodes.Status200OK;
                                result = JsonConvert.SerializeObject(new { code = "900", message = "Token Validation Has Failed. Request Access Denied" });
                                context.Response.ContentType = "application/json";
                                await context.HttpContext.Response.WriteAsync(result);
                            }

                        }
                    },
                    OnAuthenticationFailed = async (context) =>
                     {
                         if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                         {
                             //context.Response.StatusCode = 200;
                             DentistResponse response = new();
                             string result;
                             response.Message = "Token has expired";
                             response.Code = "901";
                             if (!context.Response.HasStarted)
                             {                  
                                 context.Response.StatusCode = StatusCodes.Status200OK;
                                 result = JsonConvert.SerializeObject(new { code = "901", message = "Token has expired" });
                                 context.Response.ContentType = "application/json";
                                 await context.HttpContext.Response.WriteAsync(result);
                             }



                         }
                     }
                };

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DentisBooking.Api v1"));
            }
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
