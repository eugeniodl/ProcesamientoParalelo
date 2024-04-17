using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public class StringProcessor
    {
        private readonly IRepository<string> _repository;

        public StringProcessor(IRepository<string> repository)
        {
             _repository = repository;
        }

        public List<string> FilterStrings() =>
            _repository.GetAll().AsParallel().Where(s => s.Contains("W")).ToList(); 
        
    }
}
