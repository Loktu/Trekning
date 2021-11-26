using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace ReplyToMany
{
   public partial class ReplyForm : Form
   {
      public ReplyForm()
      {
         InitializeComponent();
         this.confirmAll.Checked = true;
         this.orginalText.Checked = true;
         this.acceptedOnly.Checked = false;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var outlookApplication = new Microsoft.Office.Interop.Outlook.Application();
         var outlookExplorer = outlookApplication.ActiveExplorer();
         if (outlookExplorer == null)
         {
            MessageBox.Show("No outlook found!");
            return;
         }

         string melding = "Vil du sende e-post til disse?";
         string liste = "";
         bool warn = true;
         foreach (Object item in outlookExplorer.Selection)
         {
            Microsoft.Office.Interop.Outlook._MailItem mail = item as Microsoft.Office.Interop.Outlook._MailItem;
            if (mail != null)
            {
               liste += mail.SenderName + "\n";
            }
            else
            {
               var meeting = item as Microsoft.Office.Interop.Outlook._MeetingItem;
               AppointmentItem appointment = item as AppointmentItem;
               SendPurring(appointment);
               warn = false;
            }
         }

         if (liste.Length < 1)
         {
            if (warn)
               MessageBox.Show("No e-post selected!");
            return;
         }

         var res = MessageBox.Show(liste, melding, MessageBoxButtons.YesNo);
         if (res == System.Windows.Forms.DialogResult.Yes)
         {
            foreach (MailItem mail in outlookExplorer.Selection)
            {
               string navn = mail.SenderName;
               if (string.IsNullOrEmpty(navn))
                  continue;

               MailItem reply = ((Microsoft.Office.Interop.Outlook._MailItem)mail).Reply();
               if (!SendMail(reply, navn))
                  break;
            }
         }

      }

      private void SendPurring(AppointmentItem appointment)
      {
         foreach (Recipient recipient in appointment.Recipients)
         {
            if (acceptedOnly.Checked)
            {
               if (recipient.MeetingResponseStatus == OlResponseStatus.olResponseAccepted ||
                   recipient.MeetingResponseStatus == OlResponseStatus.olResponseOrganized)
               {
                  MailItem mail = appointment.ForwardAsVcal();
                  mail.To = recipient.Address;
                  if (!SendMail(mail, recipient.Name))
                     break;
               }
            }
            else
            {
               if (recipient.MeetingResponseStatus == OlResponseStatus.olResponseNone ||
                   recipient.MeetingResponseStatus == OlResponseStatus.olResponseNotResponded)
               {
                  MailItem mail = appointment.ForwardAsVcal();
                  mail.To = recipient.Address;
                  if (!SendMail(mail, recipient.Name))
                     break;
               }
            }
         }
      }

      public bool SendMail(_MailItem reply, string navn)
      {

         string body = reply.Body;
         if (body != null)
         {
            int lengde = reply.Body.IndexOf("From: Arve Loktu");
            if (lengde > 0)
               body = body.Substring(0, lengde);
         }

         reply.Body = this.textBox.Text;
         var splittet = navn.Split(' ');

         if (reply.Body.Contains("<navn>"))
         {
            reply.Body = reply.Body.Replace("<navn>", navn);
         }
         if (reply.Body.Contains("<fornavn>"))
         {
            string fornavn = splittet[0];
            if (splittet.Length > 2)
               fornavn += " " + splittet[1];
            reply.Body = reply.Body.Replace("<fornavn>", fornavn);
         }
         if (reply.Body.Contains("<etternavn>"))
         {
            string etternavn = splittet[splittet.Length - 1];
            reply.Body = reply.Body.Replace("<etternavn>", etternavn);
         }

         if (orginalText.Checked)
            reply.Body += "\n" + body;

         if (this.confirmAll.Checked)
         {
            var res = MessageBox.Show(reply.Body, "Vil du virkelig sende dette til " + reply.To, MessageBoxButtons.YesNoCancel);
            if (res == System.Windows.Forms.DialogResult.Yes)
               reply.Send();
            else if (res == System.Windows.Forms.DialogResult.Cancel)
               return false;
         }
         else
            reply.Send();
         return true;
      }

      private void textBox_TextChanged(object sender, EventArgs e)
      {
         if (textBox.Text.StartsWith("Skriv en melding her:"))
         {
            textBox.Text = textBox.Text.Remove(0, 23);
         }
      }

   }
}
