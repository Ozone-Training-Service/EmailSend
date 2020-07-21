﻿using System;
using System.Net;
using System.Net.Mail;

namespace EmailSend
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int otp = rn.Next(1000);
            string OTP = otp.ToString();


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); 

            mail.From = new MailAddress("FromEmail@gamil.com"); // From

            mail.To.Add("Toemail@gmail.com");// To
            mail.Subject = "OTP ";
            mail.Body = "YOUR OTP="+ OTP;


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("FromEmail@gamil.com", "emailPassword");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);


            Console.WriteLine("Send"+OTP);
            Console.ReadLine();
        }
    }
}
