using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game.voData;

namespace game.model
{
    public class UserModel : IUserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public int Level { get; set; }
        public string AvatarPath { get; set; }
        public int Coins { get; set; }
        public int Gems { get; set; }
        public int LeaderboardRank { get; set; }
        public List<vORendererData> DataRenderer { get; set; } = new List<vORendererData>();
    }
}
