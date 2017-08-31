using System;
using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
    public class ReviewDto : BaseDto
    {
        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "متن پیام اجباری میباشد")]
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
        public Guid AnswerId { get; set; }
        public string UserIp { get; set; }
        public bool Suggestion { get; set; }

        public ReviewDto Answer { get; set; }
    }
}