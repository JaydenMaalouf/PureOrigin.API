using Newtonsoft.Json;

namespace PureOrigin.API.Classes.Search
{
    internal class OriginUserSearchItem
    {
        [JsonProperty("friendUserId")]
        public string UserId { get; internal set; }
    }
}
