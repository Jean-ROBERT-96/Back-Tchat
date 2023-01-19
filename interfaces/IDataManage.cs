using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tchat.interfaces
{
    public interface IDataManage<T>
    {
        bool Add(T item);
        bool Edit(T item);
        bool Delete(T item);
    }
}
