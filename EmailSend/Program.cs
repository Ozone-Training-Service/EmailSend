using System;
using System.Net;
using System.Net.Mail;

namespace EmailSend
{

    class EmailSend
    {
        public void SendEmail(string toAddress,string msg,string subject)
        {
            Random rn = new Random();
            int otp = rn.Next(1000);
            string OTP = otp.ToString();


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("vishnukumarps2017@gmail.com"); // From

            mail.To.Add(toAddress);// To
            mail.Subject =subject;
            mail.Body = msg;


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("vishnukumarps2017@gmail.com", "vISHNU@123");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Email");
            string To = Console.ReadLine();
            Console.WriteLine("Enter Sub");
            string sub = Console.ReadLine();
            Console.WriteLine("Enter msg");
            string msg = Console.ReadLine();

            EmailSend ob = new EmailSend();
            ob.SendEmail(To,msg,sub);



            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
