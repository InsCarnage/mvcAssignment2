﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.Extensions.Configuration;

namespace SendgridMailApp.Controllers
{
    [Route("api/[controller]")]
    public class NotificationController : Controller
    {
        private readonly IConfiguration _configuration;

        public NotificationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("SendNotification")]
        public async Task PostMessage()
        {
            var apiKey = _configuration.GetSection("ApiKey").Value;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("InsCarnage@gmail.com", "Example User 1");
            List<EmailAddress> tos = new List<EmailAddress>
          {
              new EmailAddress("Jeandre610@gmail.com", "Example User 2"),
          };

            var subject = "Hello world email from Sendgrid ";
            var htmlContent = "<strong>Hello world with HTML content</strong>";
            var displayRecipients = false; // set this to true if you want recipients to see each others mail id 
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, "", htmlContent, false);
            var response = await client.SendEmailAsync(msg);
        }
    }
}