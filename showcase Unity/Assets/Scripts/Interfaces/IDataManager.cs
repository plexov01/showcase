namespace Interfaces
{
    public interface IDataManager<T>
    {
        public T GetDataСontainer();
        public void SetDataСontainer(T container);
        public string GetObjectStringIdByIndex(int index);
    }
}