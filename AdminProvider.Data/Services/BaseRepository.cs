using AdminProvider.Data.Interfaces;
using AdminProvider.Domain.Factories;
using AdminProvider.Domain.Models;

namespace AdminProvider.Data.Services;

public abstract class BaseRepository<T> : IBaseRepository<T>
//Skalla fungera för alla olika repositories. Grundfunktionalitet. Spara ned är uppgiften.
{
    private readonly List<T> _items = []; //Generell Lista här
    public ResponseResult<T> Create(T entity)
    //Lägg till try catch
    {
        _items.Add(entity);

        return ResponseFactory<T>.Success(entity);
    }

    public ResponseResult<IEnumerable<T>> GetAll()
    {
        return ResponseFactory<IEnumerable<T>>.Success(_items);
    }

    public ResponseResult<T> GetOne(Func<T, bool> predicate)
    {
        var entity = _items.FirstOrDefault(predicate);

        if (entity != null)
        {
            return ResponseFactory<T>.Success(entity);
        }
        return ResponseFactory<T>.NotFound(entity!);
    }

}
