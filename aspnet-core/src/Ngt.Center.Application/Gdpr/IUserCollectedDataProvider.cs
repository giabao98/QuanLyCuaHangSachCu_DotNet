using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Ngt.Center.Dto;

namespace Ngt.Center.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
