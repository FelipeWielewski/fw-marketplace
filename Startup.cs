using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FW.Marketplace.Interfaces;
using FW.Marketplace.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FW.Marketplace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //Interface que carrega arquivo de configuração -> appsettings.json
        public IConfiguration Configuration { get; }

        //metodo responsavel por adicionar serviços ao seu sistema -> d.i
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddControllers();
        }

        //utilizado para você fazer as configurações iniciais, antes de iniciar seu servidor
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //criar regras especificas para desenvolvimento
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //manipular authorização
            app.UseAuthorization();

            //definir rotas customizadas
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
