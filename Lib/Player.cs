using System;

namespace Lib
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerTeam { get; set; }
        public float PlayerMinutes { get; set; }
        public float PlayerPlusMinus {get; set; }

        public Player(int PlayerID, string PlayerName, string PlayerTeam, float PlayerMinutes, float PlayerPlusMinus)
        {
            this.PlayerID = PlayerID;
            this.PlayerName = PlayerName;
            this.PlayerTeam = PlayerTeam;
            this.PlayerMinutes = PlayerMinutes;
            this.PlayerPlusMinus = PlayerPlusMinus;
        }
    }
}
