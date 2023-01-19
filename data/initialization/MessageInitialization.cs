using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.initialization
{
    public class MessageInitialization : IDataInitialization<Message>
    {
        private readonly IDataConnect<Message> _connect;
        private const string data = "message";

        public MessageInitialization(IDataConnect<Message> connect)
        { 
            _connect = connect;
        }

        public ICollection<Message> DataInitialization()
        {
            return (ICollection<Message>)_connect.GetListConnect(data);
        }
    }
}
