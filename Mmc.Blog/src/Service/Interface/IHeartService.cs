using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface IHeartService
{
    Task Heart(HeartDto dto);
    Task UnHeart(HeartDto heartDto);
}
