using System.ComponentModel.DataAnnotations;

namespace Mmc.Api.Entities;

public class BlogEntity
{
    [Key]
    public int id { get; set; }
}