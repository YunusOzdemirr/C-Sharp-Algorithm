using System;
using System.IO;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Algorithm.Helpers
{
    public static class MailSender
    {
        //this method is sending email with attachment like excel file
        public static async Task SendEmail(string path)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("sender", "sender@test.com"));
                message.To.Add(new MailboxAddress("receiver", "receiver@gmail.com"));
                message.Subject = "Text Subject";

                var body = new TextPart("plain")
                {
                    Text = @"Text of body"
                };
                var smtpHost = "mail.test.com";
                int smtpPort = 587;

                var client = new SmtpClient();

                client.Connect(smtpHost, smtpPort, SecureSocketOptions.None);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync("noreply@test.com", "testpass");

                var attachment = new MimePart("excel", "excel")
                {
                    Content = new MimeContent(File.OpenRead(path)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    //FileName = Path.GetFileName(path)
                    FileName = "Excel File"
                };

                // now create the multipart/mixed container to hold the message text and the
                // image attachment
                var multipart = new Multipart("mixed");
                multipart.Add(body);
                multipart.Add(attachment);
                // now set the multipart/mixed as the message body
                message.Body = multipart;

                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}