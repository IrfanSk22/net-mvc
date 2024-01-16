using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    
    public CategoryRepository(ApplicationDbContext context) 
        : base(context)
    {
        _context = context;
    }

    public void Update(Category category)
    {
        _context.Categories.Update(category);
    }
}
