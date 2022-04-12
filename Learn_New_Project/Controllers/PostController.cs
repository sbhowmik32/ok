using Learn_New_Project.Context;
using Learn_New_Project.Manager;
using Learn_New_Project.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learn_New_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        PostManager _postManager;

        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _postManager = new PostManager(dbContext);
        }
        [HttpGet]
        public List<Post> GetAll()
        {
            //var posts = _dbContext.Posts.ToList();
           var posts = _postManager.GetAll().ToList();
            return posts;
        }

        [HttpPost]
        public Post Add(Post post)
        {
            post.CreatedDate = DateTime.Now;
            /*_dbContext.Posts.Add(post);
            bool isSaved = _dbContext.SaveChanges() > 0;*/
            bool isSaved = _postManager.Add(post);
            if (isSaved)
            {
                return post;
            }
            return null;
        }

    }
}
