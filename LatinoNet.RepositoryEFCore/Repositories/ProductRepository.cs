using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;


namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly LatinoNetContext Context;

        public ProductRepository(LatinoNetContext context)
        {
            Context = context;

        }

        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }

        public void Edit(Product product)
        {
            Context.Update(product);
        }

        public void Delete(Product product)
        {
            Context.Remove(product);
        }
    }
}