using Microsoft.AspNetCore.Mvc;
using DotNetSocial.Models;
using DotNetSocial.Dtos;
namespace DotNetSocial.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<Post> Get(int id)
        {
            _logger.Log(LogLevel.Information, "Getting Post with id: "+id);
            Post post = new Post{ location = "Bengaluru", caption = "Post Caption", postId = id, userId = 10};
            return Ok(post);
        }

        [HttpGet("GetTimeline")]
        public ActionResult<List<Post>> GetTimeline(int userId)
        {
            _logger.Log(LogLevel.Information, "Getting Timeline Posts for userid: "+userId);
            List<Post> posts = new List<Post>();
            posts.Add(new Post{ location = "Bengaluru", caption = "Post Caption", postId = 11, userId = 10});
            return Ok(posts);
        }


    }
}