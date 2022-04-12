using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learn_New_Project.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        //[Route("/api/name")]
        public string GetName()
        {
            return "Test";
        }
        [HttpGet]
        //[Route("/api/fullname")]
        public string GetFullName()
        {
            return "Full Name";
        }

    }
}
