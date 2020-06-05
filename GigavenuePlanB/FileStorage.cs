using System;
using System.IO;

namespace GigavenuePlanB
{
    public class FileStorage : IStorage<int,string>
    {

        public void Add()
        {
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