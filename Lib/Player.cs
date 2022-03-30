using System;

namespace Lib
{
    public class Player
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public string playerTeam { get; set; }
        public float playerMinutes { get; set; }
        public float playerPlusMinus {get; set; }

        public Player(int playerId, string playerName, string playerTeam, float playerMinutes, float playerPlusMinus)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.playerTeam = playerTeam;
            this.playerMinutes = playerMinutes;
            this.playerPlusMinus = playerPlusMinus;
        }
    }
}
