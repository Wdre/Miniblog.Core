namespace Miniblog.Core.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Angemeldet bleiben?")]
        public bool RememberMe { get; set; } = false;

        [Required]
        public string UserName { get; set; } = string.Empty;
    }
}
