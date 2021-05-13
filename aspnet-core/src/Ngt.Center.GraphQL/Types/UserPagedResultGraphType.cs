using Abp.Application.Services.Dto;
using GraphQL.Types;
using Ngt.Center.Dto;

namespace Ngt.Center.Types
{
    public class UserPagedResultGraphType : ObjectGraphType<PagedResultDto<UserDto>>
    {
        public UserPagedResultGraphType()
        {
            Field(x => x.TotalCount);
            Field(x => x.Items, type: typeof(ListGraphType<UserType>));
        }
    }
}