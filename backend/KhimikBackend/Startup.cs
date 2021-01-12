using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhimikBackend.Data.Configs.DBConfigs;
using KhimikBackend.Data.Daos;
using KhimikBackend.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KhimikBackend {
    public class Startup {
        public Startup() {
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();   
            services.AddDbContext<KhimikContext>();
            services.AddAuthorization();
            services.AddSingleton<MentorDao>();
            services.AddSingleton<MentorService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
