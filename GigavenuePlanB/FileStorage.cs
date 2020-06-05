using System;
using System.IO;
using System.Linq;

namespace GigavenuePlanB
{
    public class FileStorage : IStorage<int,string>
    {

        public void Add()
        {
        }

        private int nextId(IStoragble<int> data)
        {
            // finds max id in all records in the file, return incrementeds
            return File.ReadLines(data.returnFileStoragePath()).Max(line =>
                int.Parse(line.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]))+1;
        }

        public IStoragble<int> Add(IStoragble<int> data)
        {
            IStoragble<int> result = data;
            using (StreamWriter sw = new StreamWriter(data.returnFileStoragePath()))
            {
                sw.WriteLine(data.ConvertForFileStorage());
            }

            return result;
        }

        public IStoragble<int> Get(int identifier, string castTo)
        {
            string result = "";
            using (StreamReader sr = new StreamReader(castTo)) {
                while ((result = sr.ReadLine()) != null) {
                    // TODO
                    Console.WriteLine(result);
                }
            }
            Console.ReadKey();
            IStoragble<int> res = new GigUser(readConsole:true);
            return res;
        }

        public void Delete(int identifier, string castTo)
        {
            throw new NotImplementedException();
        }

        public IStoragble<int> Update(int identifier, string castTo)
        {
            throw new NotImplementedException();
        }
    }
}