using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.manage
{
    public class MessageManage : IDataManage<Message>
    {
        private readonly IDataConnect<Message> _connect;
        private const string data = "message";

        public MessageManage(IDataConnect<Message> connect)
        {
            _connect = connect;
        }

        public bool Add(Message item)
        {
            return _connect.PostConnect(data, item).Result;
        }

        public bool Delete(Message item)
        {
            return _connect.DeleteConnect($"{data}/{item.Id}").Result;
        }

        public bool Edit(Message item)
        {
            return _connect.PutConnect($"{data}/{item.Id}", item).Result;
        }
    }
}
