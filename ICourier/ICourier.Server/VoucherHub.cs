using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace LightSwitchApplication
{
    public class VoucherHub: Hub
    {
        static List<UserConnection> myConnList = new List<UserConnection>();
        public override System.Threading.Tasks.Task OnConnected()
        {
            string user =  Context.QueryString["user"];
            myConnList.Add(new UserConnection() { UserID = user, ConnectionID = Context.ConnectionId });
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var res = (from i in myConnList where i.ConnectionID == Context.ConnectionId select i).FirstOrDefault();
            if (res != null)
                myConnList.Remove(res);

            return base.OnDisconnected(stopCalled);
        }
        public static void NotifyClients(string dealID, string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<VoucherHub>();
            var res = (from i in myConnList where i.UserID == dealID select i);
            foreach(var conn in res)
            {
                context.Clients.Client(conn.ConnectionID).GlobalMessage(message);
            }
        }
    }
    public class UserConnection
    {
        public string UserID { get;set; }
        public string ConnectionID { get; set; }
    }
}