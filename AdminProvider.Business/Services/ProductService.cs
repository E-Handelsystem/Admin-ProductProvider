
using AdminProvider.Business.Interfaces;
using AdminProvider.Data.Interfaces;
using AdminProvider.Domain.Factories;
using AdminProvider.Domain.Models;

namespace AdminProvider.Business.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository<Product> _productRepository;

    public ProductService(IProductRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }



    public ResponseResult<Product> Create(ProductRequest productRequest)
    {
      
        var product = ProductFactory.Create(productRequest);
        var result = _productRepository.Create(product);

        if (result.Success)
        {
            return ResponseFactory<Product>.Success(result.Data!);
        }
        return ResponseFactory<Product>.NotFound(result.Data!);
    }

    public ResponseResult<IEnumerable<Product>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Product> GetOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Product> UpdateOne(Func<Product, bool> predicate, Product updatedProduct)
    {
        throw new NotImplementedException();
    }
    public ResponseResult DeleteOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

}
