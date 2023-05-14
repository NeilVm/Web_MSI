using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Web_MSI.Areas.Identity.Pages.Account
{
   public class EmailService : IEmailSender
{
    private readonly ILogger<EmailService> _logger;

    public EmailService(ILogger<EmailService> logger)
    {
        _logger = logger;
    }

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        _logger.LogInformation($"Sending email to {email} with subject '{subject}' and message '{htmlMessage}'");
        // Aquí va la lógica para enviar el correo electrónico
        return Task.CompletedTask;
    }
}
}