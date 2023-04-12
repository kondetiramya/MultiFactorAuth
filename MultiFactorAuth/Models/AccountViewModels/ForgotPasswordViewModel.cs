using System.ComponentModel.DataAnnotations;

namespace MultiFactorAuth.Models.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
