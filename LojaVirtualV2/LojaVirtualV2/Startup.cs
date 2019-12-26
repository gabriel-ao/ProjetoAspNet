using LojaVirtualV2.Database;
using LojaVirtualV2.Libraries.Login;
using LojaVirtualV2.Libraries.Sessao;
using LojaVirtualV2.Repositories;
using LojaVirtualV2.Repositories.Contracts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace LojaVirtualV2
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
            /*
             * Padrão Respository
             */

            services.AddScoped<Sessao>();

            services.AddHttpContextAccessor();

            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<INewsletterRepository, NewsletterRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });




            // -----------
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            // -----------





            //session - configuração 

            services.AddMemoryCache(); // guardar os dados na memoria

            services.AddSession(options=> {

            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            string connection = "Data source=TI-GABRIEL\\SQLEXPRESS; Initial Catalog=LojaVirtualV2; Integrated Security = true; User Id=fitcard\\gabriel.oliveira;  Password =''";

            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection) );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                routes.MapRoute(
                    name: "default",
                    template: "/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
