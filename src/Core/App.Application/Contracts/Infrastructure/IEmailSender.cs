using App.Application.Models;

namespace App.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email eamil);
    }
}