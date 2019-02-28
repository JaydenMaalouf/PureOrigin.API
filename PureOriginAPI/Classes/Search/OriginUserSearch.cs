using System.Collections.Generic;

using Newtonsoft.Json;

namespace PureOriginAPI.Classes.Search
{
    internal class OriginUserSearch
    {
        [JsonProperty("totalCount")]
        public int UserCount { get; internal set; }
        [JsonProperty("infoList")]
        public IEnumerable<OriginUserSearchItem> UserList { get; internal set; }
    }
}
