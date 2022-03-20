using Mmc.Notice.Entity;

namespace Mmc.Api.Dto;

public class NoticeMasterResponseApiModel
{
    public string Title { get; set; } = null!;
    public string? Body { get; set; }
    public string Date { get; set; }
    public string? Picture { get; set; }
}