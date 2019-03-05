using System;
using System.Collections.Generic;
using System.Text;

namespace plexserverapi.Models
{
    public class Media
    {
        [System.Xml.Serialization.XmlElement()]
        public Part Part { get; set; }
    }
}
