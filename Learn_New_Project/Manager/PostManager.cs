using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using Learn_New_Project.Context;
using Learn_New_Project.Interfaces.Manager;
using Learn_New_Project.Model;
using Learn_New_Project.Repository;

namespace Learn_New_Project.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {

        }
    }
}
