using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;
using Tchat.interfaces;

namespace Tchat.data.initialization
{
    public class UserInitialization : IDataInitialization<User>
    {
        private readonly IDataConnect<User> _connect;
        private const string data = "user";

        public UserInitialization(IDataConnect<User> connect)
        {
            _connect = connect;
        }

        public ICollection<User> DataInitialization()
        {
            return (ICollection<User>)_connect.GetListConnect(data);
        }
    }
}
