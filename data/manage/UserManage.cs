using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.manage
{
    public class UserManage : IDataManage<User>
    {
        private readonly IDataConnect<User> _connect;
        private const string data = "user";

        public UserManage(IDataConnect<User> connect)
        {
            _connect = connect;
        }

        public bool Add(User item)
        {
            return _connect.PostConnect(data, item).Result;
        }

        public bool Delete(User item)
        {
            return _connect.DeleteConnect($"{data}/{item.Id}").Result;
        }

        public bool Edit(User item)
        {
            return _connect.PutConnect($"{data}/{item.Id}", item).Result;
        }
    }
}
