using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Friendships.Dto;

namespace Ngt.Center.Friendships
{
    public interface IFriendshipAppService : IApplicationService
    {
        Task<FriendDto> CreateFriendshipRequest(CreateFriendshipRequestInput input);

        Task<FriendDto> CreateFriendshipRequestByUserName(CreateFriendshipRequestByUserNameInput input);

        Task BlockUser(BlockUserInput input);

        Task UnblockUser(UnblockUserInput input);

        Task AcceptFriendshipRequest(AcceptFriendshipRequestInput input);
    }
}
