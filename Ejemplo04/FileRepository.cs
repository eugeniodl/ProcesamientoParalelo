using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo04
{
    public class FileRepository : IRepository<string>
    {
        private string _sourceFolderPath;
        private string _destinationFolderPath;

        public FileRepository(string sourceFolderPath, 
            string destinationFolderPath)
        {
            _sourceFolderPath = sourceFolderPath;
            _destinationFolderPath = destinationFolderPath;

            // Verificar si la carpeta de destino no existe, si no, crearla
            if(!Directory.Exists(_destinationFolderPath))
                Directory.CreateDirectory(_destinationFolderPath);
        }
        public void Copy(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath, true);
        }

        public List<string> GetAll()
        {
            return Directory.GetFiles(_sourceFolderPath, "*.jpg").ToList();
        }

        public string GetDestinationFolder()
        {
            return _destinationFolderPath;
        }
    }
}
