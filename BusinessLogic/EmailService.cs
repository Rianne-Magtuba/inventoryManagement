using InventoryCommon;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Microsoft.Extensions.Configuration;

namespace BusinessLogic
{
    public class EmailService
    {
        private readonly IConfiguration _config;
      
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public void sendSupplierEmail(Product product, string supplierName, string supplierEmailAdd)
        {
            var _username = _config["EmailSettings:SmtUser"];
            var _password = _config["EmailSettings:SmtPass"];
             string SmtHost = _config["EmailSettings:SmtHost"];
             int _port = Convert.ToInt16(_config["EmailSettings:SmtPort"]);
            string senderEmail = _config["EmailSettings:FromEmail"];
            string senderName = _config["EmailSettings:FromName"];

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(senderEmail, senderEmail));
            email.To.Add(new MailboxAddress(supplierName, supplierEmailAdd));

            email.Subject = "Restock Request for " + product.Name;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<h2>Dear " + supplierName + ",</h2>" +
                "<p>We hope this message finds you well. We are reaching out to inform you that we are currently low on stock for the following product:</p>" +
                "<ul>" +
                "<li><strong>Product Name:</strong> " + product.Name + "</li>" +
                "<li><strong>Current Stock Level:</strong> " + product.Quantity + "</li>" +
                "</ul>" +
                "<p>We would appreciate it if you could expedite the restocking of this item at your earliest convenience. Please let us know the expected delivery date and any other relevant details.</p>" +
                "<p>Thank you for your prompt attention to this matter. We look forward to continuing our successful partnership.</p>" +
                "<p>Best regards,</p>"
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(SmtHost, _port, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_username, _password);
                smtp.Send(email);
                smtp.Disconnect(true);

            }
        }
    }


}
