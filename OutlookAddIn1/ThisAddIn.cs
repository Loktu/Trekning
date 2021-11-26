
namespace OutlookAddIn1
{
    public partial class ThisAddIn
    {
        //Outlook.Inspectors inspectors;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //inspectors = this.Application.Inspectors;
            //inspectors.NewInspector += new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
            //var messageForm = new MessageForm("Velkommen til Arves Outlook addin!\nNå kan alt skje.", "Melding fra oven");
            //messageForm.Show();
            //System.Windows.Forms.MessageBox.Show("Velkommen til Arves Outlook addin!\nNå kan alt skje.");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        //void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        //{
        //    Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;
        //    if (mailItem != null)
        //    {
        //        if (mailItem.EntryID == null)
        //        {
        //            mailItem.Body = "\nVennlig hilsen\n" +
        //            this.Application.Session.CurrentUser.Name;
        //        }
        //    }
        //}

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
