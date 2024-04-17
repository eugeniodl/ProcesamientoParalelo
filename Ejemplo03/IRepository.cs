using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Copy(T sourcePath, T destinationPath);
        string GetDestinationFolder();
    }
}
