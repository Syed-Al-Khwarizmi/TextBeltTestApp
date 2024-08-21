using Microsoft.Extensions.Configuration;
using TextBeltTestApp;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ensure the necessary packages are installed for ConfigurationBuilder
        var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        // Load settings from the appsettings.json
        var textBeltSettings = configuration.GetSection("TextBeltSettings");
        string apiUrl = textBeltSettings["ApiUrl"];
        string apiKey = textBeltSettings["ApiKey"];
        string sender = textBeltSettings["Sender"];

        string phoneNumber = "5555555555";
        string message = "Hello world! Here's a first-time text from the TextBelt API";

        TextMessageService textMessageService = new TextMessageService(apiUrl, apiKey);
        textMessageService.SendMessage(phoneNumber, message, sender);
    }
}
