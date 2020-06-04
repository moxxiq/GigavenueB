using System;
using System.IO;

namespace GigavenuePlanB
{
    public abstract class FileStorage : IStorage
    {
        private string file_path = "";

        public void Add()
        {
        }

        public void Add(IStoragble data)
        {
            using (StreamWriter sw = new StreamWriter(file_path))
            {
                sw.WriteLine(data.ConvertForFileStorage());
            }
        }
    }
}