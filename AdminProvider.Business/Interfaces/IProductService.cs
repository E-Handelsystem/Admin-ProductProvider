
using AdminProvider.Domain.Models;

namespace AdminProvider.Business.Interfaces;

public interface IProductService
{
    public ResponseResult<Product> Create(ProductRequest productRequest);
    public ResponseResult<IEnumerable<Product>> GetAll();
    public ResponseResult<Product> GetOne(Func<Product, bool> predicate);

    public ResponseResult<Product> UpdateOne(Func<Product, bool> predicate, Product updatedProduct);

    public ResponseResult DeleteOne(Func<Product, bool> predicate);


}

