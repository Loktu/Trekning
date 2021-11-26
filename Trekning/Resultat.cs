using System.Collections.Generic;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace Trekning
{
    public class Resultat
    {
        public class Uke
        {            
            public int Ukenr;
            public List<int> personer = new List<int>();
            public int Antall { get { return personer.Count; } }
            public int Valgt;
            public string Person;

            public void Add(int person)
            {
                if (!personer.Contains(person))
                    personer.Add(person);
            }

            public Uke(int nr)
            {
                Ukenr = nr;
            }

            public string Personer
            {
                get
                {
                    string liste = "";
                    foreach (int p in personer)
                    {
                        if (liste.Length > 0)
                            liste += ",";
                        liste += p;
                    }
                    return liste;
                }
            }
        }

        public class Ukeliste : KeyedCollection<int, Uke>, IXmlSerializable
        {
            protected override int GetKeyForItem(Uke item)
            {
                return item.Ukenr;
            }

            new public Uke this[int ukenummer]
            {
                get
                {
                    Uke uke;
                    if (this.Contains(ukenummer))
                    {
                        uke = base[ukenummer];
                    }
                    else
                    {
                        uke = new Uke(ukenummer);
                        base.Add(uke);
                    }
                    return uke;
                }
            }

            public System.Xml.Schema.XmlSchema GetSchema()
            {
                return null;
            }

            public void ReadXml(System.Xml.XmlReader reader)
            {
                reader.ReadStartElement();
                var serializer = new XmlSerializer(typeof(List<Uke>));
                var list = (List<Uke>)serializer.Deserialize(reader);
                foreach (var t in list)
                {
                    this.Add(t);
                }
                reader.ReadEndElement();
            }

            public void WriteXml(System.Xml.XmlWriter writer)
            {
                var serializer = new XmlSerializer(typeof(List<Uke>));
                var list = new List<Uke>(this);
                serializer.Serialize(writer, list);
            }
        }

        public Ukeliste uker = new Ukeliste();

        public Resultat()
        {
            //uker.Add(new Uke(52));
            //uker.Add(new Uke(53));
            //for (int i=1; i<=18; ++i)
            //{
            //    uker.Add(new Uke(i));
            //}
        }

        public void ResetUker()
        {
            foreach (Uke uke in uker)
            { 
                uke.personer.Clear();
            }
         uker.Clear();
        }

        public void AddPerson(int person, string ønsker, int valgt, string navn)
        {
            if (ønsker == null)
                ønsker = "";
            string[] ønskeliste = ønsker.Split(',');
            foreach (string suke in ønskeliste)
            {
                int ukenummer;
                if (int.TryParse(suke, out ukenummer))
                {
                    uker[ukenummer].Add(person);
                }
            }
            if (valgt != 0)
            {
                uker[valgt].Valgt = person;
                uker[valgt].Person = navn;
            }
        }
    }
}
