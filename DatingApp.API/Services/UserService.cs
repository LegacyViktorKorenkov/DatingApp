using DatingApp.API.DataContext;
using DatingApp.API.Entities;
using DatingApp.API.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Services;

public class UserService : IUserService
{
    private readonly AppDataContext _dataContext;

    public UserService(AppDataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<AppUser> GetAsync(int id) => await _dataContext.AppUsers.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<AppUser>> GetAllAsync() => await _dataContext.AppUsers.ToListAsync();
}

