using System.Threading.Tasks;

namespace PureOriginAPI.Interfaces
{
    public interface IOriginUser
    {
        string Username { get; }
        string UserId { get; }
        string PersonaId { get; }

        Task<string> GetAvatarUrlAsync(AvatarSizeType sizeType = AvatarSizeType.LARGE);
    }
}
