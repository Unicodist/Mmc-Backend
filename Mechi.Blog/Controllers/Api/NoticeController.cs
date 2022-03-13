using Mechi.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Entity;

namespace Mmc.Blog.Api;

[ApiController]
public class NoticeController
{
    [HttpGet]
    [Route("api/notice{id}")]
    public async Task<NoticeMaster?> Get(long id)
    {
        return await new NoticeServices().GetNoticeById(id);
    }
    [HttpGet]
    [Route("api/notice")]
    public async Task<List<NoticeMaster>> Get()
    {
        return await new NoticeServices().GetAll();
    }
}