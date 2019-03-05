using plexserverapi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace plexserverapi.APIClients
{
    public abstract class APIClient
    {
        /// <summary>
        /// Always start with a leading forward slash and end with a ?
        /// </summary>
        protected abstract string _endpoint { get; }
        protected PlexConfig _config;

        public APIClient(PlexConfig config)
        {
            _config = config;
        }

        protected async Task<MediaContainer> GetMediaContainerAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var serializer = new XmlSerializer(typeof(MediaContainer));
                return (MediaContainer)serializer.Deserialize(await client.GetStreamAsync(_config.BaseUrl + url));
            }
        }
    }
}
