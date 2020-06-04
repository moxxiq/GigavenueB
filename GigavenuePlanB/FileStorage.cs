using System;
using System.IO;

namespace GigavenuePlanB
{
    public class FileStorage : IStorage<int,string>
    {

        public void Add()
        {
        }

        public void Add(IStoragble<int> data, string castTo)
        {
            
            using (StreamWriter sw = new StreamWriter(castTo))
            {
                sw.WriteLine(data.ConvertForFileStorage());
            }
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
    }
}