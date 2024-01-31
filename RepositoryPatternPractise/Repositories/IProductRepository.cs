using RepositoryPatternPractise.Models;

namespace RepositoryPatternPractise.Repositories
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetProducts();
        Product GetById(int id);
        void Insert(Product product);
        void Delete(int id);    
        void Update(Product product);
        void Save();


    }
}
