using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using cbsStudents.Areas.Identity.Data;

namespace cbsStudents.Models.Entities;

public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; }
    public DateTime TimeStamp { get; set; }

    public int PostId { get; set; }
    public Post Post { get; set; }

    public string UserId { get; set; }
    public StudentPortalUser User { get; set; }


}