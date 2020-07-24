using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace EmailSend
{
    public class ExceptionHandling
    {

        public void doExceptionHandling()
        {

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Ans="+c);
                Console.WriteLine("Rest of the code");
            }
            catch (Exception ex)
            {
                using (StreamWriter wr = new StreamWriter(@"D:\ALL\Ozone Traing\Batch3\SRC2\EmailSend\EmailSend\Logs\log.txt", true))
                {

                    var date = DateTime.Now.ToShortDateString();
                    wr.Write("Date:" + date);
                    wr.Write("error" + ex.Message);
                }
            }
            Console.WriteLine("Done");


        }
    }
}
