using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class CSharpExampleDC
{
    static async Task Main(string[] args)
    {
        string proxyUsername = Environment.GetEnvironmentVariable("proxy_username");
        string proxyPassword = Environment.GetEnvironmentVariable("proxy_password");

        if (string.IsNullOrEmpty(proxyUsername) || string.IsNullOrEmpty(proxyPassword))
        {
            Console.WriteLine("Error: Proxy credentials not set. Please set proxy_username and proxy_password.");
            Console.WriteLine("Example:");
            Console.WriteLine("export proxy_username=your_username");
            Console.WriteLine("export proxy_password=your_password");
            Environment.Exit(1);
        }

        try
        {
            var proxy = new WebProxy
            {
                Address = new Uri($"http://dcp.evomi.com:2000"),
                Credentials = new NetworkCredential($"customer-{proxyUsername}", proxyPassword)
            };

            var handler = new HttpClientHandler
            {
                Proxy = proxy,
                UseProxy = true,
            };

            using (var client = new HttpClient(handler))
            {
                var response = await client.GetStringAsync("https://ip.evomi.com/");
                Console.WriteLine(response);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
