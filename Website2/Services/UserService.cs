using System;

namespace Website2.Services
{
    public class UserService
    {

        public User ActiveUser { get; set; }
        public void ClearActiveUser()
        {
            ActiveUser = null;
        }

    

        public void DoLogin(String UserName, String Password)
        {

        }
    }
}
