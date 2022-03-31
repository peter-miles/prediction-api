using System;

namespace Lib
{
    public class Players
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public string playerTeam { get; set; }
        public double playerMinutes { get; set; }
        public double playerPlusMinus {get; set; }

        public Players(int playerId, string playerName, string playerTeam, double playerMinutes, double playerPlusMinus)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.playerTeam = playerTeam;
            this.playerMinutes = playerMinutes;
            this.playerPlusMinus = playerPlusMinus;
        }
    }
}
