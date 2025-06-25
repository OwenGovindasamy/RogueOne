using RogueOne.Models;
using RogueOne.ViewModels;

namespace RogueOne.Interfaces
{
    public interface IInstagramLooter
    {
        Task<UserDescription> GetUserId(string username);
        Task<UserDetails> GetUserDetailsFromUserId(string userId);
        Task<MetaList> GetMetaListFromUserId(string userId);
        Task<ReelListDetails> GetReelsFromUserId(string userId);
    }
}