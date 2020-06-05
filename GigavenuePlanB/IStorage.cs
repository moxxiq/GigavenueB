using System;

namespace GigavenuePlanB
{
    public interface IStorage
    {
        public IStoragble Add(IStoragble data);
        public IStoragble Get(int identifier, string modelPath);
        public void Delete(int identifier, string modelPath);
        public IStoragble Update(int identifier, string modelPath);
        
    }
}