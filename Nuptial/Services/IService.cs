using System.Collections.Generic;

namespace Nuptial.Services
{
    public interface IService<T>
    {
        T GetNew();
        void Save(T entity);
        void Update(T entity);
        void Delete(int entity);
        void RollBack(int entity);
    }
}
