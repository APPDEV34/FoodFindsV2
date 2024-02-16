// ProductRepository.cs
using PupFoodFinds.DataAccess.Data;
using PupFoodFinds.DataAccess.Repository.IRepository;
using PupFoodFinds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PupFoodFinds.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetList(Expression<Func<Product, bool>> filter = null,
                                           Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null,
                                           string includeProperties = "")
        {
            IQueryable<Product> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Include additional logic for orderBy and includeProperties if needed

            return query.ToList();
        }

        public IEnumerable<Product> SearchProducts(string query)
        {
            query = query.ToLower(); // make the search case-insensitive
            return GetList(p => p.MenuItem.ToLower().Contains(query) || p.Description.ToLower().Contains(query),
                           includeProperties: "Category,ProductImages");
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb != null)
            {
                objFromDb.MenuItem = obj.MenuItem;
                objFromDb.Price = obj.Price;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;

                // Uncomment the following lines if updating the ImageUrl is needed
                // if (obj.ImageUrl != null)
                // {
                //     objFromDb.ImageUrl = obj.ImageUrl;   
                // }

                // Assuming ProductImages is a collection, you might need to update it accordingly
                objFromDb.ProductImages.Clear();
                objFromDb.ProductImages.AddRange(obj.ProductImages);
            }
        }
    }
}
