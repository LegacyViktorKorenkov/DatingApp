using DatingApp.API.DataContext;
using DatingApp.API.Entities;
using DatingApp.API.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IEnumerable<AppUser>> GetUsers() => 
        await _userService.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<AppUser> GetUser(int id) =>
        await _userService.GetAsync(id);
}