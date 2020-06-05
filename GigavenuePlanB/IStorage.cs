using System;

namespace GigavenuePlanB
{
    public interface IStorage<TIdentifier, TCastTo>
    {
        public IStoragble<TIdentifier> Add(IStoragble<TIdentifier> data);
        public IStoragble<TIdentifier> Get(TIdentifier identifier, TCastTo castTo);
        public void Delete(TIdentifier identifier, TCastTo castTo);
        public IStoragble<TIdentifier> Update(TIdentifier identifier, TCastTo castTo);
        
    }
}