using System.ComponentModel.DataAnnotations;

namespace Shop.Module.Core.Abstractions.ViewModels
{
    public class ResetPasswordPostParam
    {
        [Required(ErrorMessage = "用户名参数异常")]
        public string UserName { get; set; }
    }
}
