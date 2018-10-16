using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
