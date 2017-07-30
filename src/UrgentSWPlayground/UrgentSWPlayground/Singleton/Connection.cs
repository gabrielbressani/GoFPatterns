using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrgentSWPlayground.Singleton
{
    public sealed class Connection
    {
        private static VssConnection _connection;

        private Connection() { }

        public static VssConnection Open()
        {

            if (_connection == null)
            {
                var accountUri = new Uri("https://stratws.visualstudio.com");
                var personalAccessToken = "hv3l46ruhkmhq4qnrpq7evjsaj6onfmdhurti6kp2vmxfdwxmwoq";

                _connection = new VssConnection(accountUri, new VssBasicCredential(string.Empty, personalAccessToken));              
            }

            return _connection;
       }
    }
}
