using RepositoryPatternPractise.Data;
using RepositoryPatternPractise.Models;

namespace RepositoryPatternPractise.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
            
        }


        public void Delete(int id)
        {
            
        }

        public Product GetById(int id)
        {
            var product = _db.Products.Find(id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var allproducts = _db.Products;
            return allproducts;
        }

        public void Insert(Product product)
        {
            _db.Products.Add(product);
                                                
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            var productIndb=_db.Products.Find(product.Id);
            if(productIndb != null)
            {
                productIndb.price = product.price;
            }
          
        }
    }
}
