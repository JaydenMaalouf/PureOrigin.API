using Newtonsoft.Json;

namespace PureOriginAPI.Classes.Search
{
    internal class OriginUserSearchItem
    {
        [JsonProperty("friendUserId")]
        public string UserId { get; internal set; }
    }
}
