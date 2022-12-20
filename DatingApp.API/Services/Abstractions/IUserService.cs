using DatingApp.API.Entities;

namespace DatingApp.API.Services.Abstractions;

public interface IUserService
{
    Task<AppUser> GetAsync(int id);
    Task<IEnumerable<AppUser>> GetAllAsync();
}

