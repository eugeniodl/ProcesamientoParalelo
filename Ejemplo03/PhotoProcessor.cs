using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    public class PhotoProcessor
    {
        private readonly IRepository<string> _repository;

        public PhotoProcessor(IRepository<string> repository)
        {
            _repository = repository;
        }

        public void CopyPhotosInParallel()
        {
            List<string> photoPaths = _repository.GetAll();

            Parallel.ForEach(photoPaths, photoPath =>
            {
                string fileName = Path.GetFileName(photoPath);
                string destinationPath = 
                Path.Combine(_repository.GetDestinationFolder(), fileName);
                _repository.Copy(photoPath, destinationPath);
                Console.WriteLine($"Foto copiada: {fileName} en thread " +
                    $"{Task.CurrentId}");
            });
        }
    }
}
