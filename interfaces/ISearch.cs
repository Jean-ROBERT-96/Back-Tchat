using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchat.data.models;

namespace Tchat.interfaces
{
    public interface ISearch
    {
        ICollection<Message> SearchMessage();
    }
}
