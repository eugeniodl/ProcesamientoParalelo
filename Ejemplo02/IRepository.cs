using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T item);
    }
}
