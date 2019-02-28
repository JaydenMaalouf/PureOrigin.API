using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

using PureOrigin.API.Interfaces;

namespace PureOrigin.API
{
    [XmlRoot(ElementName = "user")]
    public class OriginUser : IOriginUser
    {
        [XmlElement("EAID")]
        public string Username { get; set; }

        [XmlElement("userId")]
        public string UserId { get; set; }

        [XmlElement("personaId")]
        public string PersonaId { get; set; }

        public async Task<string> GetAvatarUrlAsync(AvatarSizeType sizeType = AvatarSizeType.LARGE)
        {
            var request = OriginAPI.CreateRequest(HttpMethod.Get, $"https://api1.origin.com/avatar/user/{UserId}/avatars?size={(int)sizeType}");

            var response = await OriginAPI.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(content))
                {
                    var regex = Regex.Match(content, @"<link>(.*?)<\/link>");
                    if (regex.Success)
                    {
                        return regex.Value.Replace("<link>", "").Replace("</link>", "");
                    }
                }
            }
            return null;
        }
    }
}
