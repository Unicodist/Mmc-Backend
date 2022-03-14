using Mmc.Notice.Entity;

namespace Mmc.Api.Dto;

public class NoticeMasterListResponseApiModel
{
    public string Title { get; set; } = null!;
    public string? Body { get; set; }
    public string Date { get; set; }
    public string Picture { get; set; }
}