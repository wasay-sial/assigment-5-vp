using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting.Server;

namespace ssignment_05.Models
{
    public static class CitiesRepository
    {
        public static List<string> GetCities()
        {
            return new List<string>
            {
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
            };
        }

    }

    public static class ServersRepository
    {
        // A static list to simulate a database
        private static List<Server> servers = new List<Server>
        {
            new Server { Id = 1, Name = "Server 1", City = "Toronto", IsOnline = true },
            new Server { Id = 2, Name = "Server 2", City = "Montreal", IsOnline = false },
            new Server { Id = 3, Name = "Server 3", City = "Ottawa", IsOnline = true },
            new Server { Id = 4, Name = "Server 4", City = "Calgary", IsOnline = false },
            new Server { Id = 5, Name = "Server 5", City = "Halifax", IsOnline = true },
        };

        // Method to get all servers
        public static List<Server> GetServers()
        {
            return servers;
        }

        // Method to search servers by name or city
        public static List<Server> SearchServers(string searchTerm)
        {
            return servers
                .Where(s => s.Name.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase) ||
                            s.City.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Method to delete a server by ID
        public static void DeleteServer(int serverId)
        {
            var server = servers.FirstOrDefault(s => s.Id == serverId);
            if (server != null)
            {
                servers.Remove(server);
            }
        }
    }

}

