using AutoStrada.DAL;
using AutoStrada.ENT;
using System.Linq;

namespace AutoStrada.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DatabaseContext _context;

        public ProductsRepository(DatabaseContext context)
        {
            _context = context;
        }        

        public int Count()
        {
            return GetActives().Count();
        }

        private IQueryable<Product> GetActives()
        {
            return _context.Products.Where(p => p.State);
        }

        public PaginatedProduct GetProducts(int page = 1, int productsPerPage = 10)
        {
            return PaginatedProduct.ToPaginatedProduct(
                GetActives().OrderBy(x => x.CodeProduct), page, productsPerPage);
        }

        public PaginatedProduct GetByCode(int codeProduct)
        {
            return PaginatedProduct.ToPaginatedProduct(
                GetActives().Where(x => x.CodeProduct == codeProduct), 1, 1);
        }

        public int Add(Product product)
        {
            if (product.DateFabrication >= product.DateValidity)
                throw new System.Exception("El campo de fecha de fabricación que no puede ser mayor o igual a la fecha de vencimiento.");

            _context.Products.Add(product);
            _context.SaveChanges();
            return product.CodeProduct;

        }

        public int Update(Product product)
        {
            if (product.DateFabrication >= product.DateValidity)
                throw new System.Exception("El campo de fecha de fabricación que no puede ser mayor o igual a la fecha de vencimiento.");
            
            _context.Products.Update(product);
            return _context.SaveChanges();

        }

        public int Remove(Product product)
        {
            product.State = false;
            _context.Products.Update(product);
            return _context.SaveChanges();
        }
    }
}
