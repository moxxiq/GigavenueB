using System;

namespace GigavenuePlanB
{
    public interface IStorage<TIdentifier, TCastTo>
    {
        public void Add(IStoragble<TIdentifier> data, TCastTo castTo);
        public IStoragble<TIdentifier> Get(TIdentifier identifier, TCastTo castTo);
        
    }
}