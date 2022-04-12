using EF.Core.Repository.Repository;
using Learn_New_Project.Context;
using Learn_New_Project.Interfaces.Repository;
using Learn_New_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Learn_New_Project.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
