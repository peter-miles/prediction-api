namespace Lib
{
    public class Team
    {
        public int teamId;
        public string teamName { get; set; }
        public int playerId1 { get; set; }
        public int playerId2 { get; set; }
        public int playerId3 { get; set; }
        public int playerId4 { get; set; }
        public int playerId5 { get; set; }

        public Team(int teamId, string teamName, int playerId1, int playerId2, int playerId3, int playerId4, int playerId5)
        {
            this.teamId = teamId;
            this.teamName = teamName;
            this.playerId1 = playerId1;
            this.playerId2 = playerId2;
            this.playerId3 = playerId3;
            this.playerId4 = playerId4;
            this.playerId5 = playerId5;
        }
    }
}
