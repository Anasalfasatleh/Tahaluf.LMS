using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.IServices;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Infra.Common;
using Tahaluf.LMS.Infra.Repository;
using Tahaluf.LMS.Infra.Services;

namespace Tahaluf.LMS.API
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
            services.AddAuthentication(
                x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
                ).AddJwtBearer(y =>
                {
                    y.RequireHttpsMetadata = false;
                    y.SaveToken = true;
                    y.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true, 
                        IssuerSigningKey =new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[Hello my Name is Anas Ahmad Alfasatleh]")),
                        ValidateIssuer = false,
                        ValidateAudience = false
                     };
                });

            services.AddControllers();

            //DbContext 
            services.AddScoped<IDbContext, DbContext>();

            //Repositories
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
            services.AddScoped<ITeacherCourseRepository, TeacherCourseRepository>();
            services.AddScoped<IJWTRepository, JWTRepository>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<ICoursesRepository, CoursesRepository>();

            //Services
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITeacherServices, TeacherServices>();
            services.AddScoped<ILoginServices, LoginServices>();
            services.AddScoped<IBookServices, BookServices>();
            services.AddScoped<IStudentServices, StudentServices>();
            services.AddScoped<IStudentCourseServices, StudentCourseServices>();
            services.AddScoped<ITeacherCourseServices, TeacherCourseServices>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ICoursesServices, CoursesServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
