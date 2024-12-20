﻿using iwantedue;
using iwantedue.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Trekning
{
    public partial class MainForm : Form
    {
        string fileName = "Navneliste.xml";
        public MainForm()
        {
            InitializeComponent();
            dataGridViewPerson.DataSource = Program.trekningDataSet.Tables["Person"];
            DataTable personer = Program.trekningDataSet.Tables["Person"];

            foreach (DataRow row in personer.Rows)
            {
                try
                {
                    string ønsker = (string)row["Ønsker"];
                    row["Rest"] = ønsker;
                }
                catch
                {
                    row["Rest"] = "";
                }
            }

            dataGridViewTrekning.DataSource = Program.trekningDataSet.Tables["Trekning"];
            dataGridViewTrekning.AutoResizeColumns();
            dataGridViewTrekning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void SaveData()
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.FileName = fileName;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try { Program.trekningDataSet.WriteXml(fileDialog.FileName, XmlWriteMode.IgnoreSchema); }
                catch { }
            }
        }

        public void ReadData()
        {
            userControlResultat.RemoveEvents();

            Program.trekningDataSet.Clear();

            var fileDialog = new OpenFileDialog();
            fileDialog.FileName = fileName;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try { Program.trekningDataSet.ReadXml(fileDialog.FileName); }
                catch { }
            }
            Program.trekningDataSet.InitializeRest();
            userControlResultat.AddEvents();
            userControlResultat.SjekkTrekning();
        }

        private void PersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void dataGridViewPerson_DragDrop(object sender, DragEventArgs e)
        {
            //wrap standard IDataObject in OutlookDataObject
            OutlookDataObject dataObject = new OutlookDataObject(e.Data);

            //get the names and data streams of the files dropped
            string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
            MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

            for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
            {
                //use the fileindex to get the name and data stream
                string filename = filenames[fileIndex];
                MemoryStream filestream = filestreams[fileIndex];
                OutlookStorage.Message message = new OutlookStorage.Message(filestream);

                string navn = message.From;
                string body = message.BodyText;

                int from = body.IndexOf("From:");
                if (from > 0)
                {
                    body = body.Substring(0, from);
                }
                var lines = body.Split(new char[] { '\r', '\n', '\t' });
                var ønsker = FinnØnsker(lines);
                if (string.IsNullOrEmpty(navn))
                    return;

                userControlResultat.RemoveEvents();
                Program.trekningDataSet.AddPerson(navn, ønsker);
                userControlResultat.AddEvents();

                message.Dispose();

            }

        }


        private void dataGridViewPerson_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        ///  Analyserer innholdet i mail for å finne kommaseparert liste
        /// </summary>
        /// <param name="linjer"></param>
        /// <returns></returns>
        string FinnØnsker(string[] linjer)
        {
            //Finn vedlikeholdsuker
            var vedlikeholdstekst = vedlikehold.Text.Trim().Split(',');
            List<int> vedlikeholdsuker = new List<int>();
            foreach (var uketekst in vedlikeholdstekst)
            {
                int uke;
                if (int.TryParse(uketekst, out uke))
                {
                    vedlikeholdsuker.Add(uke);
                }

            }

            string ønsker = "";
            foreach (string l in linjer)
            {
                string linje = "";
                foreach (char c in l)
                {
                    if (c == ',' || c == '-' || c == '.' || c == ';')
                    {
                        if (linje.Length > 0 && !linje.EndsWith("" + c))
                            linje += ',';
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        linje += c;
                    }
                }
                linje = linje.TrimEnd(',');
                if (linje.Length == 0)
                    continue;

                string[] test = linje.Split(new char[] { ',', '-' });
                linje = "";
                foreach (string testString in test)
                {
                    int itest;
                    if (int.TryParse(testString, out itest))
                    {
                        if (!vedlikeholdsuker.Contains(itest))
                        {
                            if (itest >= 0 && itest < 55)
                            {
                                if (linje.Length > 0)
                                    linje += ",";
                                linje += testString;
                            }
                        }
                    }
                }
                if (linje.Length > 0)
                {
                    // Looks ok
                    ønsker = linje;
                    break;
                }
            }
            return ønsker;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string resultat = Program.trekningDataSet.GetRestultat();

            var outlookApplication = new Microsoft.Office.Interop.Outlook.Application();
            var outlookExplorer = outlookApplication.ActiveExplorer();

            string melding = "Vil du sende e-post til disse? (de som er valgt i outlook)";

            DialogResult res = System.Windows.Forms.DialogResult.No;

            while (res == DialogResult.No)
            {
                string liste = "";
                try
                {
                    foreach (MailItem mail in outlookExplorer.Selection)
                    {
                        liste += mail.SenderName + "\n";
                    }
                    res = MessageBox.Show(liste, melding, MessageBoxButtons.YesNoCancel);
                }
                catch
                {
                    res = MessageBox.Show("Du må velge de e-postene di skal svare på før du trykker OK.", "Ingen valgte e-poster", MessageBoxButtons.OKCancel);
                    if (res == System.Windows.Forms.DialogResult.OK)
                        res = System.Windows.Forms.DialogResult.No;
                }

            }

            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (MailItem mail in outlookExplorer.Selection)
                {
                    string navn = mail.SenderName;
                    string personligMelding = Program.trekningDataSet.GetPersonligMelding(navn, (int)jul.Value, (int)vinterferie.Value, (int)paaske.Value);
                    var deltNavn = navn.Split(' ');
                    string hei = "Hei " + deltNavn[0];
                    if (deltNavn.Length > 2)
                        hei += " " + deltNavn[1];
                    hei += "\n";

                    _MailItem reply = ((Microsoft.Office.Interop.Outlook._MailItem)mail).Reply();

                    reply.Body = hei + personligMelding + resultat;

                    Button button = sender as Button;
                    if (button.Text == "Test")
                    {
                        string[] bodyLines = reply.Body.Split('\n');
                        if (bodyLines.Length < 30)
                        {
                            res = MessageBox.Show(reply.Body, "Vil du virkelig sende dette til " + reply.To, MessageBoxButtons.YesNoCancel);
                        }
                        else
                        {
                            res = System.Windows.Forms.DialogResult.Yes;
                        }
                        if (res == System.Windows.Forms.DialogResult.Yes)
                            reply.Send();
                        else if (res == System.Windows.Forms.DialogResult.Cancel)
                            break;
                    }
                    else
                        reply.Send();

                }
            }
        }

        private void buttonSjekk_Click(object sender, EventArgs e)
        {
            userControlResultat.SjekkTrekning();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            userControlResultat.ClearTrekning();
        }

        private void trekkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlResultat.RemoveEvents();
            DataTable trekning = Program.trekningDataSet.Tables["Trekning"];
            trekning.Rows.Clear();

            DataTable person = Program.trekningDataSet.Tables["Person"];
            int n = person.Rows.Count;
            List<int> pointers = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                pointers.Add(i);
            }
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                int r = rnd.Next(0, pointers.Count);
                int p = pointers[r];
                trekning.Rows.Add(p);
                pointers.Remove(p);
            }
            userControlResultat.SjekkTrekning();
            userControlResultat.AddEvents();
        }
    }
}
