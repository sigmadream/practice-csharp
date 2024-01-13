using Lear.Data.DataModels;
using Learn.Data.ViewModels;
using Learn.Services.Interfaces;

namespace Learn.Services.Svcs
{
    public class UserService : IUser
    {
        #region private methods
        private IEnumerable<User> GetUserInfos()
        {
            return new List<User>
            {
                new User {
                    UserId = "admin",
                    UserName = "관리자",
                    UserEmail = "admin@test.com",
                    Password = "qwer1234",
                }
            };
        }
        
        private bool checkTheUserInfo(string userId, string password)
        {
            return GetUserInfos().Where(u => u.UserId.Equals(userId) && u.Password.Equals(password)).Any();
        }
        #endregion

        public bool MatchTheUserInfo(LoginInfo login)
        {
            return checkTheUserInfo(login.UserId, login.Password);
        }
    }
}
