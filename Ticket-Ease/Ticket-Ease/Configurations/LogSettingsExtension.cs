using Serilog;

namespace Ticket_Ease.Configurations
{
    public static class LogSettingsExtension
    {
        public static void AddLoggingConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .WriteTo.Console()
                .WriteTo.File("C:/temp/Ticket-EaseLog.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            services.AddLogging(loggingBuilder =>
            {
                // Add Serilog
                loggingBuilder.AddSerilog();
            });
        }
    }
}
