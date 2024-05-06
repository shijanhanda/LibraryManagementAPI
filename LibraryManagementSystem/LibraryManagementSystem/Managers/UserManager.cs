namespace LibraryManagementSystem.Managers
{
    public class UserManager
    {
        private ILogger<UserManager> logger;
        public UserManager(ILogger<UserManager> logger) 
        {
            this.logger = logger;
        }

        public bool AddUser(string username, string password)
        {
            return true;
        }
    }
}
