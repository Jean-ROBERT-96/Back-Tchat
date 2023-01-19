using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tchat.interfaces
{
    public interface IDataManage<T>
    {
        void Add(T item);
        void Edit(T item);
        void Delete(T item);
    }
}
