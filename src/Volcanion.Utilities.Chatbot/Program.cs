using Microsoft.Extensions.Configuration;
using Serilog;

namespace Volcanion.Utilities.Chatbot;

internal class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();


        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

        Log.Information("Ứng dụng bắt đầu chạy");

        // Chạy ứng dụng
        try
        {
            Log.Information("Chạy chương trình");
            // Logic của ứng dụng
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Ứng dụng kết thúc đột ngột");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
