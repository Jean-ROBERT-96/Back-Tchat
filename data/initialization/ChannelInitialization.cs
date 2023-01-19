using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.initialization
{
    public class ChannelInitialization : IDataInitialization<Channel>
    {
        private readonly IDataConnect<Channel> _connect;
        private const string data = "channel";

        public ChannelInitialization(IDataConnect<Channel> connect)
        {
            _connect = connect;
        }

        public ICollection<Channel> DataInitialization()
        {
            return (ICollection<Channel>)_connect.GetListConnect(data);
        }
    }
}
