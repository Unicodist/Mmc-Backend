using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mechi.Backend.Models.Notice;

[Table("notice_master")]
public class NoticeMaster
{
    [Key]
    public int Id { get; set; }
    [Column("subject")]
    public string Subject { get; set; }
    [Column("body")]
    public string Body { get; set; }
    [Column("author_id")] 
    public DateTime DateTime { get; set; }
}