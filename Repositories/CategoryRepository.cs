using ACP_learn.Interfaces;
using ACP_learn.Models;
using Microsoft.EntityFrameworkCore;

namespace ACP_learn.Repositories
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> allCaterories => appDbContent.Categories;
    }
}