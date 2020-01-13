using System;

namespace Application.Comments
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Username { get; set; }
        public String DisplayName { get; set; }
        public String Image { get; set; }
    }
}