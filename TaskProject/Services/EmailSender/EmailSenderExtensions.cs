using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace TaskProject.Services.EmailSender
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailToUserAsync(email, "����������� ���� ����������� �����",
                $"���������� ����������� ��� ������� ������� �� ��� ������: <a href='{HtmlEncoder.Default.Encode(link)}'>����������� ����������� �����</a>");
        }
    }
}
