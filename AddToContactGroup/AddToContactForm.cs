using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace AddToContactGroup
{
    public partial class AddToContactForm : Form
    {
        Microsoft.Office.Interop.Outlook.Application outlookApplication;
        Explorer outlookExplorer = null;
        DistListItem contactList = null;
        DataTable members;
        public AddToContactForm()
        {
            InitializeComponent();

            outlookApplication = new Microsoft.Office.Interop.Outlook.Application();
            outlookExplorer = outlookApplication.ActiveExplorer();

            members = new DataTable("Members");
            members.Columns.Add("Navn");
            members.Columns.Add("Epost");

            dataGridView1.DataSource = members;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (contactList == null)
            {
                MessageBox.Show("Velg deg en kontaktgruppe først!");
                return;
            }

            foreach (var selected in outlookExplorer.Selection)
            {
                if (selected is MailItem)
                {
                    MailItem mail = selected as MailItem;
                    Recipient member = outlookApplication.Session.CreateRecipient(mail.SenderName);
                    member.AddressEntry = mail.Sender;

                    if (member.Resolve())
                    {
                        AddToList(member);
                    }

                    foreach (Recipient recipient in mail.Recipients)
                    {
                        AddToList(recipient);
                    }

                }
                else if (selected is AppointmentItem)
                {
                    AppointmentItem meeting = selected as AppointmentItem;
                    foreach (Recipient recipient in meeting.Recipients)
                    {
                        AddToList(recipient);
                    }
                }
                else if (selected is ContactItem)
                {
                    var contact = selected as ContactItem;
                    var recipient = outlookApplication.Session.CreateRecipient(contact.FullName);
                    if (recipient.Resolve())
                    {
                        AddToList(recipient);
                    }
                }
                else if (selected is DistListItem)
                {
                    var list = selected as DistListItem;
                    for (int i = 1; i<=list.MemberCount; ++i)
                    {
                        var member = list.GetMember(i);
                        AddToList(member);
                    }
                }
                else
                {
                    //string test = "feil";
                }

            }
            contactList.Save();
        }

        public bool AddToList(Recipient member)
        {
            for (int m = 1; m <= contactList.MemberCount; ++m)
            {
                var oldMember = contactList.GetMember(m);
                if (oldMember != null)
                {
                    if (oldMember.Name == member.Name)
                        return false;
                }
            }
            contactList.AddMember(member);

            var row = members.NewRow();
            row["Navn"] = member.Name;
            row["Epost"] = member.Address;
            members.Rows.Add(row);

            return true;
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Object item in outlookExplorer.Selection)
            {
                if (item is Microsoft.Office.Interop.Outlook.DistListItem)
                {
                    contactList = item as DistListItem;
                    textBox1.Text = contactList.DLName;
                    members.Clear();

                    for (int m = 1; m <= contactList.MemberCount; ++m)
                    {
                        var member = contactList.GetMember(m);
                        if (member != null)
                        {
                            var row = members.NewRow();
                            row["Navn"] = member.Name;
                            row["Epost"] = member.Address;
                            members.Rows.Add(row);
                        }
                    }
                    members.AcceptChanges();
                }
            }
        }
    }
}
