using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NetEscapades.Extensions.Logging.RollingFile;

namespace LearnASPNETCoreMVCWithRealApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(builder => builder.AddFile(
                options => {
                    options.FileName = "diagnostics-"; // The log file prefixes
                    options.LogDirectory = "LogFiles"; // The directory to write the logs
                    options.FileSizeLimit = 20 * 1024 * 1024; // The maximum log file size (20MB here)
                    options.Extension = "txt"; // The log file extension
                    options.Periodicity = PeriodicityOptions.Hourly; // Roll log files hourly instead of daily.
                }))
            .UseStartup<Startup>();
    }
}
