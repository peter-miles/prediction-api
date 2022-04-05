namespace Lib
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public User(int UserID, string UserName)
        {
            this.UserID = UserID;
            this.UserName = UserName;
        }
    }
}
