using System;
using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Comment body cannot be longer than 500 characters.")]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateTimePosted { get; set; }
    }
}
