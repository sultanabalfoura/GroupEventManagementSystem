using System;
namespace ActivitySystem.BLL.Interface
{
	public interface IGenericRepository<T>
	{
        IEnumerable<T> GetAll();
        T Get(int id);
        int Create(T item);
        int Update(T item);
        int Delete(T item);
    }
}

