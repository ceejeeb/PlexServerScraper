using plexserverapi;
using plexserverapi.APIClients;
using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new PlexConfig();

            Console.WriteLine("Hello to the plex server api test app.");
            do
            {
                Console.WriteLine("Please enter your plex server token:");
                config.Token = Console.ReadLine();
                Console.WriteLine("Please enter your plex server base url:");
                config.BaseUrl = Console.ReadLine();
                Console.WriteLine($"Thanks  are these correct (y/n)? Token:{config.Token} Url:{config.BaseUrl}");
            } while (Console.ReadLine() == "n");

            var Client = new LibrarySection(config);
            var data = Client.GetRecentlyAddedAsync("2").Result;

            data.Video.ToList().ForEach(v =>
            {
                Console.WriteLine($"{v.title} - {v.originallyAvailableAt.ToShortDateString()}");
                Console.WriteLine(v.summary);
                Console.WriteLine();
            });
            Console.ReadLine();

        }

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
