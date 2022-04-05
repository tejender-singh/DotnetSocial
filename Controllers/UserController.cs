using Microsoft.AspNetCore.Mvc;
using DotNetSocial.Models;
using DotNetSocial.Dtos;
namespace DotNetSocial.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public ActionResult<UserDto> Get(int id)
    {
        _logger.Log(LogLevel.Information, "Getting User with id: "+id);
        UserDto user = new UserDto {userId = 9 , active =  true, contact = "8860614996", email = "tejmani6@gmail.com", isPublicProfile = true};
        return Ok(user);
    }

    [HttpPost("Register")]
    public ActionResult<User> Post(User request)
    {
        _logger.Log(LogLevel.Information, "Posting User "+request);
        return Ok(request);
    }

    [HttpPut("Update")]
    public ActionResult<User> Put(User request)
    {
        _logger.Log(LogLevel.Information, "Putting User "+ request);
        return Ok(request);
    }

    [HttpDelete("Delete")]
    public ActionResult<User> Delete(int id)
    {
        _logger.Log(LogLevel.Information, "Deleting User with id: "+ id);
        return Ok(id);
    }

    [HttpGet("Follows")]
    public ActionResult<List<UserDto>> GetFollows(int id)
    {
        _logger.Log(LogLevel.Information, "Getting Users followed by userId: "+id);
        List<UserDto> users = new List<UserDto>();
        users.Add(new UserDto {userId = 9 , active =  true, contact = "8860614996", email = "tejmani6@gmail.com", isPublicProfile = true});
        return Ok(users);
    }

    [HttpGet("Followers")]
    public ActionResult<List<UserDto>> GetFollowers(int id)
    {
        _logger.Log(LogLevel.Information, "Getting Followers of userId: "+id);
        List<UserDto> users = new List<UserDto>();
        users.Add(new UserDto {userId = 9 , active =  true, contact = "8860614996", email = "tejmani6@gmail.com", isPublicProfile = true});
        return Ok(users);
    }

    [HttpPut("Follow")]
    public ActionResult<User> PutFollow(int followerId, int followedId)
    {
        _logger.Log(LogLevel.Information, "Adding a follow entry for follower: "+ followerId + ", followed:" + followedId);
        return Ok(followedId);
    }

    [HttpDelete("Follow")]
    public ActionResult<User> DeleteFollow(int followerId, int followedId)
    {
        _logger.Log(LogLevel.Information, "Removing a follow entry for follower: "+ followerId + ", followed:" + followedId);
        return Ok(followedId);
    }

}
