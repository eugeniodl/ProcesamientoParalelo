using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    public class StringRepository : IRepository<string>
    {
        private string[] _strings;

        public StringRepository(string[] strings)
        {
            _strings = strings;
        }
        public IEnumerable<string> GetAll()
        {
            return _strings;
        }
    }
}
