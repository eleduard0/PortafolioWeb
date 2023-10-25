using PortafolioWeb.Models;
namespace PortafolioWeb.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
