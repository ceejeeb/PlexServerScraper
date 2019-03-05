using System;
using System.Collections.Generic;
using System.Text;

namespace plexserverapi.Models
{
    public class MediaContainer
    {
        [System.Xml.Serialization.XmlElement()]
        public Video[] Video { get; set; }
    }
}
