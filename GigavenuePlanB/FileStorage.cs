using System;
using System.IO;
using System.Linq;

namespace GigavenuePlanB
{
    public class FileStorage : IStorage
    {

        public void Add()
        {
        }

        public int nextId(string castTo)
        {
            // finds max id in all records in the file, return incrementeds
            return File.ReadLines(castTo).Max(line =>
                int.Parse(line.Split(',', StringSplitOptions.RemoveEmptyEntries)[0]));
        }

        public IStoragble Add(IStoragble data)
        {
            data.setIdentifier(nextId(data.returnFileStoragePath()));
            IStoragble result = data;
            using (StreamWriter sw = new StreamWriter(data.returnFileStoragePath()))
            {
                sw.WriteLine(data.ConvertForFileStorage());
            }

            return result;
        }

        public IStoragble Get(int identifier, string castTo)
        {
            string result = "";
            string line = File.ReadLines(castTo).Where(line => int.Parse(line.Split(',', StringSplitOptions.RemoveEmptyEntries))[0]==identifier).ToString();
            
            Console.ReadKey();
            IStoragble res = new GigUser(readConsole:true);
            return res;
        }

        public void Delete(int identifier, string castTo)
        {
            throw new NotImplementedException();
        }

        public IStoragble Update(int identifier, string castTo)
        {
            throw new NotImplementedException();
        }
    }
}