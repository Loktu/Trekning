using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Trekning
{
    public partial class FormResultat : Form
    {

        public FormResultat()
        {
            InitializeComponent();

            DataGridViewColumn column;

            column = new DataGridViewTextBoxColumn();
            column.Name = "Uke";
            column.ValueType = typeof(int);
            dataGridViewResultat.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Person";
            column.ValueType = typeof(int);
            dataGridViewResultat.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Valgt";
            column.ValueType = typeof(int);
            dataGridViewResultat.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Antall";
            column.ValueType = typeof(int);
            dataGridViewResultat.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Ønsker";
            column.ValueType = typeof(int);
            dataGridViewResultat.Columns.Add(column);

            InitializeUker();
            FillGrid();
            AddEvents();
       }

        void AddEvents()
        {
            DataTable trekning = Program.trekningDataSet.Tables["Trekning"];
            trekning.RowChanged += new DataRowChangeEventHandler(trekning_RowChanged);

            DataTable person = Program.trekningDataSet.Tables["Person"];
            person.RowChanged += new DataRowChangeEventHandler(person_RowChanged);

        }
        void RemoveEvents()
        {
            DataTable trekning = Program.trekningDataSet.Tables["Trekning"];
            trekning.RowChanged -= new DataRowChangeEventHandler(trekning_RowChanged);

            DataTable person = Program.trekningDataSet.Tables["Person"];
            person.RowChanged -= new DataRowChangeEventHandler(person_RowChanged);
        }

        void trekning_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            SjekkTrekning();
        }

        void person_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            SjekkTrekning();
        }

        public void FillGrid()
        {
            dataGridViewResultat.Rows.Clear();
            foreach (Resultat.Uke uke in Program.resultat.uker)
            {
                int irow = dataGridViewResultat.Rows.Add();
                DataGridViewRow row = dataGridViewResultat.Rows[irow];
                row.Cells["Uke"].Value = uke.Ukenr;
                row.Cells["Valgt"].Value = uke.Valgt;
                row.Cells["Person"].Value = uke.Person;
                row.Cells["Antall"].Value = uke.Antall;
                row.Cells["Ønsker"].Value = uke.Personer;
            }
         dataGridViewResultat.Sort(dataGridViewResultat.Columns[0], ListSortDirection.Ascending);
        }

        public void InitializeUker()
        {
            Resultat resultat = Program.resultat;
            DataTable personer = Program.trekningDataSet.Tables["Person"];

            resultat.ResetUker();
            foreach (DataRow row in personer.Rows)
            {
                int person = (int)row["Nr"];
                string rest = row["Rest"] as string;
                string navn = row["Navn"] as string;
                int valgt;
                try {valgt = (int)row["Valgt"];}
                catch { valgt = 0; }
                resultat.AddPerson(person, rest, valgt, navn);
            }
        }

        public void SjekkTrekning()
        {
            RemoveEvents();
            InitializeUker();
            DataTable trekning = Program.trekningDataSet.Tables["Trekning"];
            Program.trekningDataSet.InitializeRest();

            foreach (DataRow row in trekning.Rows)
            {
                try
                {
                    int person = (int)row["Person"];
                    string rest = Program.trekningDataSet.GetRest(person);
                    var uker = rest.Split(',');

                    int n = uker.GetLength(0);
                    int valgt;
                    if (n < 1 || uker[0].Length < 1)
                    {
                        valgt = 0;
                    }
                    else
                    {
                        valgt = int.Parse(uker[0]);
                    }
                    Program.trekningDataSet.SetValgt(person, valgt);
                }
                catch
                {
                    MessageBox.Show("Skriv person nr under Person!");
                }
            }
            InitializeUker();
            FillGrid();
            AddEvents();
        }

        private void buttonSjekk_Click(object sender, EventArgs e)
        {
            SjekkTrekning();
        }

    }
}
