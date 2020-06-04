namespace GigavenuePlanB
{
    public interface IStoragble<TIdentifier>
    {
        public string ConvertForFileStorage();
        //public ... ConvertForDbStorage(); 
        public int getIdentifier();
        public void setIdentifier(TIdentifier identifier);

    }
}