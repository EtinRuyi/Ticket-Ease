using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Ease.Persistence.Repositories;

namespace Ticket_Ease.Persistence.Extensions
{
    public static class DIServiceExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration config)
        {

            //Bind CloudinarySettings from configuration 
            var cloudinarySettings = new CloudinarySetting();
            config.GetSection("CloudinarySettings").Bind(cloudinarySettings);
            services.AddSingleton(cloudinarySettings);

            var emailSettings = new EmailSettings();
            config.GetSection("EmailSettings").Bind(emailSettings);
            services.AddSingleton(emailSettings);




            // services.AddDbContext<DataContext>();

            // services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICloudinaryServices, CloudinaryServices>();




        }
    }
}
