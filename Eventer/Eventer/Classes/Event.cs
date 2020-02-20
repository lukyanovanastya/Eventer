using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Eventer.Classes
{
    [Serializable]
    public class Event
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        //Dictionary<String, String> tags;
        public string country { get; set; }
        public string city { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string site { get; set; }
        public HashSet<string> tags { get; set; }

        public Event() { }

        public Event (string name, string country, string city, string type, string subtype, string site, HashSet<string> tags)
        {
            this.name = name;
            this.country = country;
            this.city = city;
            this.type = type;
            this.subtype = subtype;
            this.site = site;
            this.tags = tags;
        }

        /*
        public Event (FileStream fs)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Event));
            using (fs)
            {
                Event ev = (Event)formatter.Deserialize(fs);
                this.name = ev.name;
                this.country = ev.country;
                this.city = ev.city;
                this.type = ev.type;
                this.subtype = ev.subtype;
                this.site = ev.site;
                this.tags = ev.tags;
            }
        }
        */

        public static Event FromXml(FileStream fs)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Event));
            using (fs)
            { return (Event)formatter.Deserialize(fs); }
        }

        public HashSet<string> editTags(HashSet<string> newTags)
        {
            this.tags = newTags;
            return tags;
        }

        private void ToXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Event));
            using (FileStream fs = new FileStream("events.xml", FileMode.OpenOrCreate))          //?????
            {
                formatter.Serialize(fs, this);
            }
        }
    }
}
