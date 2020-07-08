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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sendEmail()
    {

        Debug.Log("This UPDATE button was clicked");
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
        Debug.Log("output-->" + output);

        //send emal
        configureEmail(output);

        //save to file
        byte[] bytes = Encoding.ASCII.GetBytes(output);

        string path = "./360render.txt";
        Debug.Log(path);
        File.WriteAllBytes(path, bytes);
        Debug.Log("360 render saved to " + path);

    }

    void configureEmail(string body)
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("rao.shreya502@gmail.com");
        mail.To.Add("shreya.patil502@gmail.com");
        mail.Subject = "Your shortlisted travel destinations from Easy Vacay";
        mail.Body = body;

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("rao.shreya502@gmail.com", "Shoppingshopping@502") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
        Debug.Log("success");

    }
}
