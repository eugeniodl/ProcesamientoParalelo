using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public class StringRepository : IRepository<string>
    {
        private List<string> _strings = new List<string>();

        public StringRepository(int count, int length)
        {
            GenerateRandomStrings(count, length);
        }

        private void GenerateRandomStrings(int count, int length)
        {
            var random = new Random();
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuv0123456789";

            for (int i = 0; i < count; i++)
            {
                char[] stringChars = new char[length];
                for (int j = 0; j < length; j++)
                {
                    stringChars[j] = characters[random.Next(characters.Length)];
                }
                _strings.Add(new string(stringChars));
            }
        }

        public void Add(string item)
        {
            _strings.Add(item);
        }

        public List<string> GetAll()
        {
            return _strings;
        }
    }
}
