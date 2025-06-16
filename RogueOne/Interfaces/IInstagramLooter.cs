using RogueOne.ViewModels;

namespace RogueOne.Interfaces
{
    public interface IInstagramLooter
    {
        Task<UserDescription> GetUserId(string username);
    }
}