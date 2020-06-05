namespace GigavenuePlanB
{
    public interface IStoragble
    {
        public string ConvertForFileStorage();
        //public ... ConvertForDbStorage(); 
        public int getIdentifier();
        public void setIdentifier(int identifier);
        public string returnFileStoragePath(); // ALWAYS REALIZE STATIC ANALOGY
        //public ... returnDbTablePath(); 
    }
}