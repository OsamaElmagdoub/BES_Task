namespace BES_Task.Data.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin or User // we can make it as enum
    }
}
