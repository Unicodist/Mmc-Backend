using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mechi.Backend.Models.Blog;

[Table("blog_master")]
public class BlogMaster
{
    [Key]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("author_admin_id")]
    public int AuthoAdminId { get; set; }
    [Column("body")]
    public string Body { get; set; }
    [Column("date")]
    public DateTime DateTime { get; set; }
    [Column("author_name")]
    public string AuthorName { get; set; }
}