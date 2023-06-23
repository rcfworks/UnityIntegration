using System.Collections.Generic;
using game.voData;

namespace game.model
{
    public interface IUserModel
    {
        string UserName { get; set; }
        string Email { get; set; }
        string UserId { get; set; }
        int Level { get; set; }
        string AvatarPath { get; set; }
        int Coins { get; set; }
        int Gems { get; set; }
        int LeaderboardRank { get; set; }
        List<vORendererData> DataRenderer { get; set; }
    }
}
