using Csharp.Components.Models;

namespace ServersRepository{
    public static class ServersRepository{
        private static List<Server> servers = new List<Server>(){
            new Server{ ServerId = 1, ServerName = "Server 1", City = "Kitwe"},
            new Server{ ServerId = 2, ServerName = "Server 2", City = "Lusaka"},
            new Server{ ServerId = 3, ServerName = "Server 3", City = "Kabwe"},
            new Server{ ServerId = 4, ServerName = "Server 4", City = "Kapiri"},
            new Server{ ServerId = 5, ServerName = "Server 5", City = "Choma"},
            new Server{ ServerId = 6, ServerName = "Server 6", City = "Livingstone"},
            new Server{ ServerId = 7, ServerName = "Server 7", City = "Ndola"},
            new Server{ ServerId = 8, ServerName = "Server 8", City = "Luapula"},
            new Server{ ServerId = 9, ServerName = "Server 9", City = "Monze"},
            new Server{ ServerId = 10, ServerName = "Server 10", City = "Katete"},
            new Server{ ServerId = 11, ServerName = "Server 11", City = "Mingu"},
            new Server{ ServerId = 12, ServerName = "Server 12", City = "Lukanga"},
            new Server{ ServerId = 13, ServerName = "Server 13", City = "Kalulushi"},
            new Server{ ServerId = 14, ServerName = "Server 14", City = "Katete"},
            new Server{ ServerId = 15, ServerName = "Server 15", City = "Mansa"},
            new Server{ ServerId = 16, ServerName = "Server 16", City = "Luwingu"}
        };

        //Adding a new server to the list
        public static void AddServer(Server server){
            var maxId = servers.Max(s => s.ServerId);
            server.ServerId = maxId + 1;
            servers.Add(server);
        }

        //Getting All the servvers
        public static List<Server> GetServers() => servers;

        //Get Servers by city
        public static List<Server> GetServersByCity(string cityName){
            return servers.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //Get Server by Id
        public static Server? GetServerById(int serverId){
            var server = servers.FirstOrDefault(s => s.ServerId == serverId);
            if(server is not null){
                return new Server{
                    ServerId = server.ServerId,
                    ServerName = server.ServerName,
                    City = server.City,
                    IsOnline = server.IsOnline
                };
            }
            return null;
        }
    }
}