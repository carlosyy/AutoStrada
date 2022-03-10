using AutoStrada.DAL;
using AutoStrada.ENT;

namespace AutoStrada.Repositories
{
    public interface IProductsRepository
    {
        PaginatedProduct GetProducts(int page = 1, int productsPerPage = 10);
        PaginatedProduct GetByCode(int codeProduct);
        int Add(Product product);
        int Update(Product product);
        int Remove(Product product);
        int Count();
    }
}

