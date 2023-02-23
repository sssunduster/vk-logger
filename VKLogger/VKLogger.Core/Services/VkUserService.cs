using VKLogger.Core.Entities;
using VKLogger.Core.Interfaces;

namespace VKLogger.Core.Services
{
    public class VkUserService : IVkUserService
    {
        public async Task<VkUser> GetUserById(string id)
        {
            return new VkUser();
        }
    }
}
