using HRProject.Areas.Settings.Services;
using HRProject.Areas.Structure.Services;
using HRProject.Resource;
using HRProject.Security;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HRProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HRContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            });
            services.AddScoped<CompanyService>();
            services.AddScoped<ContactTypeService>();
            services.AddScoped<CountryService>();
            services.AddScoped<DismissalTypesService>();
            services.AddScoped<DocumentTypeService>();
            services.AddScoped<EducationInstituteService >();
            services.AddScoped<EducationLevelService>();
            services.AddScoped<LocalitiesService>();
            services.AddScoped<BranchService>();
            services.AddScoped<StructureTypeService>();
            services.AddScoped<StructureService>();
            services.AddScoped<IssuedOrganizationService>();
            services.AddScoped<StaffTypeService>();

            services.AddScoped<OrganizationStructureService>();
            services.AddScoped<KnowledgeLevelService>();
            services.AddScoped<LanguageService>();
            services.AddScoped<ExcludedDayService>();
            services.AddScoped<PrivilegeService>();

            services.AddScoped<RelationshipTypeService>();

            services.AddScoped<SkillService>();
            services.AddScoped<SpecialitieService>();
            services.AddScoped<WorkTypeService>();
            services.AddScoped<TransportService>();
            services.AddScoped<MartialStatusService>();
            services.AddScoped<PositionService>();

            services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddMvc()
    .AddDataAnnotationsLocalization(options =>
    {
        var type = typeof(SharedResource);
        var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
        var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
        var localizer = factory.Create(typeof(SharedResource));
        options.DataAnnotationLocalizerProvider = (t, f) => localizer;
    })
    .AddViewLocalization();

            services.Configure<RequestLocalizationOptions>(op =>
            {
                var supportedLanguages = new List<CultureInfo>
                {
                    new CultureInfo("az"),
                    new CultureInfo("en"),
                 
                };
                op.DefaultRequestCulture = new RequestCulture("az");
                op.SupportedCultures = supportedLanguages;
                op.SupportedUICultures = supportedLanguages;
            });

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            //    {
            //        options.LoginPath = new PathString("/login");
            //        options.AccessDeniedPath = new PathString("/forbidden");
            //        options.LogoutPath = new PathString("/logout");
            //    });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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
                //app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "areas",
               pattern: "{area:exists}/{controller=Company}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
