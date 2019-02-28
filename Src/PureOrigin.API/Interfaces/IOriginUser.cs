using System.Threading.Tasks;

namespace PureOrigin.API.Interfaces
{
    public interface IOriginUser
    {
        string Username { get; }
        string UserId { get; }
        string PersonaId { get; }

        Task<string> GetAvatarUrlAsync(AvatarSizeType sizeType = AvatarSizeType.LARGE);
    }
}
