using VKLogger.Core.Entities;

namespace VKLogger.Core.Interfaces
{
    public interface IVkUserService
    {
        Task<VkUser> GetUserById(string id);
    }
}
