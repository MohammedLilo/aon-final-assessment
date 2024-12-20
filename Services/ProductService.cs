using aon_final_assessment.Contexts;
using aon_final_assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace aon_final_assessment.Services
{
    public class ProductService
    {
        private MainDBContext dbContext;

        public ProductService(MainDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Product?> FindByIdAsync(long id)
        {
            return await dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task SaveAsync(Product product)
        {
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
        }
    }
}
