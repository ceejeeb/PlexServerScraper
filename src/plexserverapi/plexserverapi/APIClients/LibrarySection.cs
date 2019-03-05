using plexserverapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plexserverapi.APIClients
{
    public class LibrarySection : APIClient
    {
        protected override string _endpoint => "/library/sections/{0}/all?";

        public LibrarySection(PlexConfig config) : base(config) { }

        public async Task<MediaContainer> GetRecentlyAddedAsync(string sectionKey)
        {
            var fullendpoint = String.Format(_endpoint, sectionKey);
            var queryStrings = new Dictionary<string, string>
            {
                { _config.SortKey, _config.SortDateAddedDescValue },
                { _config.PContainerStartKey, "0" },
                { _config.ContainerSizeKey, "5" },
                { _config.TokenKey, _config.Token }
            };

            fullendpoint = fullendpoint + String.Join("&", queryStrings.Select(d => d.Key + "=" + d.Value));

            return await GetMediaContainerAsync(fullendpoint);
        }
    }
}
