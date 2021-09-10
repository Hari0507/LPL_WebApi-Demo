using System;
using System.Collections.Generic;
using System.Linq;
using UserInfoApi.DataBaseContext;
using UserInfoApi.Models;

namespace UserInfoApi.Services
{
    public class UserInfoService:IUserInfo
    {
        private UserDBContext _userDBContext;
        public UserInfoService(UserDBContext userDBContext)
        {
            this._userDBContext = userDBContext;
        }

        public UserDetails AddUser(UserDetails userInfo)
        {
            _userDBContext.UserInfoDetails.Add(userInfo);
            _userDBContext.SaveChanges();
            return userInfo;
        }

        public IEnumerable<UserDetails> GetAllUsers()
        {
            return _userDBContext.UserInfoDetails.ToList();
        }

        public UserDetails GetUserInfo(int Id)
        {
            return _userDBContext.UserInfoDetails.Find(Id);
        }
    }
}
