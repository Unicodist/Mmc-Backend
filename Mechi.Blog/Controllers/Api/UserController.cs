using Mechi.Backend.Dto;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Services;
using Mmc.Core.Entity;

namespace Mmc.Blog.Api;

[ApiController]
public class UserController
{
    [HttpGet]
    [Route("api/user/get{id}")]
    public async Task<UserMaster?> Get(long id)
    {
        return await new UserServices().GetUserById(id).ConfigureAwait(false);
    }

    [HttpPost]
    [Route("api/user/create{model}")]
    public async Task Create(UserCreateDto model)
    {
        await new UserServices().Create(model);
    }
}