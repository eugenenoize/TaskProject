using System.ComponentModel.DataAnnotations;

namespace TaskProject.Models.AccountViewModels
{
	public class ExternalLoginViewModel
    {
        [Required(ErrorMessage = "������� ���� ����������� �����")]
        [EmailAddress]
        [Display(Name = "����������� �����")]
        public string Email { get; set; }
    }
}
