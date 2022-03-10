using AutoStrada.DAL;
using AutoStrada.Repositories;

namespace AutoStrada.Services
{
    public class DataService : IDataService
    {
        private readonly DatabaseContext _context;

        public DataService(DatabaseContext context)
        {
            _context = context;
        }

        public IProductsRepository Products => new ProductsRepository(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
