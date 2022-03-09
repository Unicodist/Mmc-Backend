using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmc.Data;

namespace Mmc.Entities;

public class BlogMaster : BaseDbContext
{
    [Key]
    public int id { get; set; }
    [Column("title")] public string Title { get; set; }
    [Column("author_admin_id")] private int _authorAdminId { get; set; }
    [Column("body")] public string Body { get; set; }
    [Column("date")] public DateTime PostedDate { get; set; }
    [Column("author_name")] public string AuthorName { get; set; }
    
    public UserMaster? AuthorAdmin { get; set; }
}