﻿using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn1
{
    partial class AddContactFormRegion
    {
        #region Form Region Factory

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Contact)]
        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.DistributionList)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("OutlookAddIn1.AddContactFormRegion")]
        public partial class AddContactFormRegionFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void AddContactFormRegionFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void AddContactFormRegion_FormRegionShowing(object sender, System.EventArgs e)
        {
            Outlook.DistListItem contactList = this.OutlookItem as Outlook.DistListItem;
            textBox1.Text = contactList.DLName;
            FillList(contactList);
        }

        private void FillList(Outlook.DistListItem contactList)
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("EPost", "E-post");

            for (int m = 1; m <= contactList.MemberCount; ++m)
            {
                var member = contactList.GetMember(m);
                if (member != null)
                {
                    var rowIndex = dataGridView1.Rows.Add();
                    var row = dataGridView1.Rows[rowIndex];
                    row.Cells["Name"].Value = member.Name;
                    row.Cells["EPost"].Value = member.Address;
                    row.Tag = member;
                }
            }
        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void AddContactFormRegion_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void dataGridView1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = System.Windows.Forms.DragDropEffects.Copy;
        }

        private void dataGridView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            var formats = e.Data.GetFormats();
            var outlookApplication = new Microsoft.Office.Interop.Outlook.Application();
            var outlookExplorer = outlookApplication.ActiveExplorer();

            if (outlookExplorer == null)
                return;

            foreach (var selected in outlookExplorer.Selection)
            {
                if (selected is Outlook.MailItem)
                {
                    var mail = selected as Outlook.MailItem;
                    Outlook.Recipient member = outlookApplication.Session.CreateRecipient(mail.SenderName);
                    member.AddressEntry = mail.Sender;
                    if (member.Resolve())
                    {
                        AddToList(member);
                    }
                    foreach (Outlook.Recipient recipient in mail.Recipients)
                    {
                        AddToList(recipient);
                    }

                }
                else if (selected is Outlook.AppointmentItem)
                {
                    var meeting = selected as Outlook.AppointmentItem;
                    foreach (Outlook.Recipient recipient in meeting.Recipients)
                    {
                        AddToList(recipient);
                    }
                }
                else if (selected is Outlook.ContactItem)
                {
                    var contact = selected as Outlook.ContactItem;
                    var recipient = outlookApplication.Session.CreateRecipient(contact.FullName);
                    if (recipient.Resolve())
                    {
                        AddToList(recipient);
                    }
                }
                else if (selected is Outlook.DistListItem)
                {
                    var list = selected as Outlook.DistListItem;
                    for (int i = 1; i <= list.MemberCount; ++i)
                    {
                        var member = list.GetMember(i);
                        AddToList(member);
                    }
                }
                else
                {
                    string test = "feil";
                }

            }

        }

        public void AddToList(Outlook.Recipient member)
        {
            var contactList = this.OutlookItem as Outlook.DistListItem;

            for (int m = 1; m <= contactList.MemberCount; ++m)
            {
                var oldMember = contactList.GetMember(m);
                if (oldMember != null)
                {
                    if (oldMember.Name == member.Name)
                        return;
                }
            }
            contactList.AddMember(member);

            var rowIndex = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[rowIndex];
            row.Cells["Name"].Value = member.Name;
            row.Cells["EPost"].Value = member.Address;
            row.Tag = member;
        }

    }
}
