using System.Collections.Generic;

namespace SaveSystem.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetItem(int serialNumber);
        void Edit(T item);
        List<T> GetAllItems();
    }
}