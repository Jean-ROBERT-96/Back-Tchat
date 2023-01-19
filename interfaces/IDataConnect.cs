using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tchat.interfaces
{
    public interface IDataConnect<T>
    {
        Task<ICollection<T>> GetListConnect(string controller);
        Task<bool> PostConnect(string controller, T obj);
        Task<bool> PutConnect(string controllerId, T obj);
        Task<bool> DeleteConnect(string controllerId);
    }
}
