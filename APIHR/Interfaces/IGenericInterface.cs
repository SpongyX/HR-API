using APIHR.Helpers;

namespace APIHR.Interfaces
{
    public interface IGenericInterface<T> where T : class
    {
        ResponseRequest FetchAll();
        ResponseRequest FetchById(int id);
        ResponseRequest IsExisst(int id);
        ResponseRequest Add(T entity);
        ResponseRequest Delete(int id);
        ResponseRequest Update(T entity);
        ResponseRequest Save();
    }
}
