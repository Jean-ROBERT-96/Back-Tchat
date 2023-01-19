using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.manage
{
    public class ChannelManage : IDataManage<Channel>
    {
        private readonly IDataConnect<Channel> _connect;
        private const string data = "channel";

        public ChannelManage(IDataConnect<Channel> connect)
        {
            _connect = connect;
        }

        public bool Add(Channel item)
        {
            return _connect.PostConnect(data, item).Result;
        }

        public bool Delete(Channel item)
        {
            return _connect.DeleteConnect($"{data}/{item.Id}").Result;
        }

        public bool Edit(Channel item)
        {
            return _connect.PutConnect($"{data}/{item.Id}", item).Result;
        }
    }
}
