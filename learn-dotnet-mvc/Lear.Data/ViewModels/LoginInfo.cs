using System.ComponentModel.DataAnnotations;

namespace Learn.Data.ViewModels
{
    public class LoginInfo
    {
        [Required(ErrorMessage = "사용자 아이디를 입력하세요.")]
        [MinLength(4, ErrorMessage = "사용자 아이디는 4자 이상 입력하세요.")]
        [Display(Name = "사용자 아이디")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [MinLength(4, ErrorMessage = "비밀번호는 4자 이상 입력하세요.")]
        [Display(Name = "비밀번호")]
        public string Password { get; set; }
    }
}
