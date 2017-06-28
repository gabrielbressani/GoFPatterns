using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoFPatterns.Creational.Singleton.Entities
{
    public sealed class DataCenter
    {
        private static readonly DataCenter _instance = new DataCenter();
        private readonly List<Server> _servers;

        // Constructor is private not to use new
        private DataCenter()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" }
            };
        }

        public static DataCenter GetInstance()
        {
            return _instance;
        }
    }
}
