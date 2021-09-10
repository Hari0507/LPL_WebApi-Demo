using System;
using System.Collections.Generic;
using UserInfoApi.Models;

namespace UserInfoApi.Services
{
    public interface IUserInfo
    {
        UserDetails GetUserInfo(int Id);
        IEnumerable<UserDetails> GetAllUsers();
        UserDetails AddUser(UserDetails userInfo);
    }
}
