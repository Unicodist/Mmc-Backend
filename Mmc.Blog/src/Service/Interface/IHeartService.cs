using Mmc.Blog.Dto;

namespace Mmc.Blog.Service.Interface;

public interface IHeartService
{
    Task Heart(HeartDto dto);
    Task UnHeart(HeartDto heartDto);
}
