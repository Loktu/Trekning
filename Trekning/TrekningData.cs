using System;
using System.Data;
using System.Globalization;

namespace Trekning
{
    public class TrekningData : System.Data.DataSet
    {

        public TrekningData()
        {
            var tablePerson = this.Tables.Add("Person");
            var column = tablePerson.Columns.Add("Nr", typeof(int));
            column.AutoIncrement = true;
            column = tablePerson.Columns.Add("Navn", typeof(string));
            tablePerson.Columns.Add("Ønsker", typeof(string));
            column = tablePerson.Columns.Add("Rest", typeof(string));
            tablePerson.Columns.Add("Valgt", typeof(int));

            var tableTrekning = this.Tables.Add("Trekning");
            tableTrekning.Columns.Add("Person", typeof(int));
        }

        public void InitializeRest()
        {
            DataTable personer = this.Tables["Person"];
            foreach (DataRow row in personer.Rows)
            {
                string ønsker = row["Ønsker"] as string;
                row["Rest"] = ønsker;
            }
        }

        public string GetRest(int i)
        {
            var tablePerson = this.Tables["Person"];
            foreach (DataRow row in tablePerson.Rows)
            {
                int n = (int)row["Nr"];
                if (n == i)
                {
                    return (string)row["Rest"];
                }
            }
            return "";
        }

        public void SetRest(int i, string r)
        {
            var tablePerson = this.Tables["Person"];
            foreach (DataRow row in tablePerson.Rows)
            {
                int n = (int)row["Nr"];
                if (n == i)
                {
                    row["Rest"] = r;
                }
            }
        }

        public void SetValgt(int i, int v)
        {
            var tablePerson = this.Tables["Person"];
            foreach (DataRow row in tablePerson.Rows)
            {
                int n = (int)row["Nr"];
                if (n == i)
                {
                    row["Valgt"] = v;
                    row["Rest"] = "";
                }
                else
                {
                    string rest;
                    try
                    {
                        rest = (string)row["Rest"];
                    }
                    catch
                    {
                        rest = "";
                    }
                    string[] ukeliste = rest.Split(',');
                    rest = "";
                    foreach (string u in ukeliste)
                    {
                        int iu = 0;
                        if (u.Length > 0)
                        {
                            try { iu = int.Parse(u); }
                            catch { iu = 0; }
                        }
                        if (iu != v)
                        {
                            if (rest.Length > 0)
                                rest += ",";
                            rest += u;
                        }
                    }
                    row["Rest"] = rest;
                }
            }
        }

        public void AddPerson(string navn, string ønsker)
        {
            if (ønsker == null)
            {
                ønsker = "";
            }

            var table = Tables["Person"];
            bool foundRow = false;
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    try
                    {
                        if (navn == (string)row["Navn"])
                        {
                            row["Ønsker"] = ønsker;
                            row["Rest"] = ønsker;
                            foundRow = true;
                            break;
                        }
                    }
                    catch { }
                }
            }

            if (!foundRow)
            {
                var row = table.NewRow();
                row["Navn"] = navn;
                row["Ønsker"] = ønsker;
                row["Rest"] = ønsker;
                table.Rows.Add(row);
            }
        }

        public string DatoText(int jul, int vinterferie, int paaske, int ukenummer)
        {
            string datoText;
            if (ukenummer == jul)
            {
                datoText = "julehelga";
            }
            else if (ukenummer == jul + 1)
            {
                datoText = "nyttåshelga";
            }
            else
            {
                // Find year.
                int year = DateTime.Today.Year + 1;
                // Find friday in week 1
                DateTime friday = new DateTime(year, 1, 2);
                while (friday.DayOfWeek != DayOfWeek.Friday)
                {
                    friday = friday.AddDays(1);
                }

                DateTime day1 = friday.AddDays(7*(ukenummer-1));
                DateTime day2 = day1.AddDays(2);

                datoText = "";
                if (ukenummer == vinterferie - 1)
                {
                    datoText = "første del av vinterferien, som er ";
                    day2 = day1.AddDays(5);
                }
                else if (ukenummer == vinterferie)
                {
                    datoText = "siste del av vinterferien, som er ";
                    day1 = day1.AddDays(-2);
                }
                else if (ukenummer == paaske - 1)
                {
                    datoText = "første del av påsken, som er ";
                    day2 = day1.AddDays(5);
                }
                else if (ukenummer == paaske)
                {
                    datoText = "siste del av påsken, som er ";
                    day1 = day1.AddDays(-2);
                    day2 = day2.AddDays(1);
                }

                if (day1.Month == day2.Month)
                {
                    datoText += day1.Day + " - " + day2.Day + " " +
                        CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[day1.Month - 1];
                }
                else
                {
                    datoText += day1.Day + " " +
                                    CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[day1.Month - 1] +
                                    " - " + day2.Day + " " +
                                    CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[day2.Month - 1];
                }
            }
            return datoText;
        }

        internal string GetPersonligMelding(string person, int jul, int vinterferie, int paaske)
        {
            string personligMelding = "";
            Resultat.Uke funnetUke = null;
            foreach (Resultat.Uke uke in Program.resultat.uker)
            {
                if (uke.Person == person)
                {
                    funnetUke = uke;
                    break;
                }
            }

            if (funnetUke == null)
            {
                personligMelding = "Desverre, du fikk ingen helg denne gangen.\n";
                personligMelding += "Sjangsen for at det blir avbestillinger er stor, så det blir sikkert nye muligheter.\n";
            }
            else
            {
                personligMelding = "Du ble den heldige vinner av uke nr: " + funnetUke.Ukenr + ".\n";
                string datoText = DatoText(jul, vinterferie, paaske, funnetUke.Ukenr);
                if (!string.IsNullOrEmpty(datoText))
                    personligMelding += "Det vil si " + datoText + ".\n";
            }
            return personligMelding;
        }

        internal string GetRestultat()
        {
            string resultat = "\nOg vinnerne er:\n\n";
            resultat += "Uke \tPerson\n";
            foreach (Resultat.Uke uke in Program.resultat.uker)
            {
                if (!string.IsNullOrEmpty(uke.Person))
                    resultat += uke.Ukenr + " \t" + uke.Person + "\n";
            }
            return resultat;
        }

    }
}
