using System.Net;
using System.Net.Mail;

namespace MailAutomation;

internal class MailAutomation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the mail address to send to:");
        string recipientEmail = Console.ReadLine();
        
        string subject = "Your Subject";
        string body = "Body Content";

        string attachmentFilePath = @"Attachment File Path";
        
        string senderEmail = "youremail@gmail.com"; 
        string senderPassword = "your-app-password";     

        try
        {
            // Create Mail Message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            if (recipientEmail != null) mail.To.Add(recipientEmail);
            mail.Subject = subject;
            mail.Body = body;

            // Add Attachment
            if (attachmentFilePath != null) mail.Attachments.Add(new Attachment(attachmentFilePath));
            

            // Create SMTP Client
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // If you use Gmail
            smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtp.EnableSsl = true;

            // Send Mail
            smtp.Send(mail);

            Console.WriteLine("Mail sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while sending the mail: " + ex.Message);
        }
    }
}