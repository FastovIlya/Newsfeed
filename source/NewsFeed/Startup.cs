using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NewsFeed.Interfaces.Services;
using NewsFeed.Mapper;
using NewsFeed.Models.JWT;
using NewsFeed.Services;

namespace NewsFeed
{
    public class Startup
    {
        public IConfiguration Configuration { get; } 

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddDbContext<NewsFeedContext> (
                options => options.UseNpgsql(
                    Configuration.GetConnectionString("NewsFeedConnection")
                )
            );
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUserService, UserService>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidIssuer = AuthOptions.ISSUER,
                            ValidateAudience = true,
                            ValidAudience = AuthOptions.AUDIENCE,
                            ValidateLifetime = true,
                            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                            ValidateIssuerSigningKey = true,
                        };
                    });
            services.AddAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            if (env.EnvironmentName == "Development")
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
