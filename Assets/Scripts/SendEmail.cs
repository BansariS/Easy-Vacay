using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

public class SendEmail : MonoBehaviour
{
 
    public void sendEmail()
    {

        string output = "";

        List<string> fnames = new List<string>();

        //extract List
        fnames = AddName.ListStrings();

        //create final message
        output = "List of destinations" + "\n";
        foreach (string value in fnames)
        {
            output = output + value + "\n";
        }

        //send emal
        configureEmail(output);

        //save to file
        byte[] bytes = Encoding.ASCII.GetBytes(output);

        string path = "./360render.txt";
        File.WriteAllBytes(path, bytes);

    }

    void configureEmail(string body)
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("reh.sh502@gmail.com");
        mail.To.Add("abc.xyz@gmail.com");
        mail.Subject = "Your shortlisted travel destinations from Easy Vacay";
        mail.Body = body;

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("abc.xyz@gmail.com", "pingshoping@52") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);

    }
}
