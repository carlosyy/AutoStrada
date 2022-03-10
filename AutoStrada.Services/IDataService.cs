using AutoStrada.Repositories;

namespace AutoStrada.Services
{
    public interface IDataService
    {
        IProductsRepository Products { get; }

        void SaveChanges();
    }
}
