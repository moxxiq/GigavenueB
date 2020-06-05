namespace GigavenuePlanB
{
    public interface IStoragble<TIdentifier>
    {
        public string ConvertForFileStorage();
        //public ... ConvertForDbStorage(); 
        public int getIdentifier();
        public void setIdentifier(TIdentifier identifier);
        public string returnFileStoragePath(); // ALWAYS REALIZE STATIC ANALOGY
        //public ... returnDbTablePath(); 
    }
}