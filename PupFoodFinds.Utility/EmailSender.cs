﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PupFoodFinds.Utility
{
    public class EmailSender : IEmailSender
    {
        //public string SendGridSecret { get; set; }

        //public EmailSender(IConfiguration _config)
        //{
        //    SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
        //}

        //public Task SendEmailAsync(string email, string subject, string htmlMessage)
        //{
        //    //logic to send email

        //    var client = new SendGridClient(SendGridSecret);

        //    var from = new EmailAddress("hello@dotnetmastery.com", "Bulky Book");
        //    var to = new EmailAddress(email);
        //    var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

        //    return client.SendEmailAsync(message);


        //}
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //logic to send email
            return Task.CompletedTask;
        }
    }
}
