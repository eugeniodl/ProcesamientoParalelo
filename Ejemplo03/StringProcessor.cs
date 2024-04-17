using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    public class StringProcessor
    {
        private readonly IRepository<string> _repository;

        public StringProcessor(IRepository<string> repository)
        {
            _repository = repository;
        }

        public IEnumerable<string> FilterStringsStartingWith(char letter)
        {
            return _repository.GetAll().Where(s => s.StartsWith(letter));
        }
    }
}
