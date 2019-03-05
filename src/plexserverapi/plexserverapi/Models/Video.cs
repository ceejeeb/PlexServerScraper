using System;
using System.Collections.Generic;
using System.Text;

namespace plexserverapi.Models
{
    public class Video
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string key { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string title { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string contentRating { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string summary { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string rating { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public DateTime originallyAvailableAt { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public long addedAt { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string thumb { get; set; }

        [System.Xml.Serialization.XmlElement()]
        public Media[] Media { get; set; }

        [System.Xml.Serialization.XmlElement()]
        public Genre[] Genre { get; set; }
    }
}
