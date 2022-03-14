using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mmc.Api.Dto;
using Mmc.Data;

namespace Mmc.Blog.Api;

[ApiController]
public class NoticeApiController
{
    private BaseDbContext _context;
    [HttpGet]
    [Route("api/notice")]
    public async Task<IList<NoticeMasterListResponseApiModel>> Get()
    {
        IList<NoticeMasterListResponseApiModel> dtos = new List<NoticeMasterListResponseApiModel>();
        var noticeMaster = _context.NoticeMasters;
        noticeMaster.ForEachAsync(x => dtos.Add(new()
        {
            Title = x.NoticeMasterTitle,
            Body = x.NoticeMasterBody,
            Date = x.PostedOn.ToString(),
            Picture = x.NoticeMasterNoticePicture
        }));
        return dtos;
    }
}