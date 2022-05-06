using System;
using Microsoft.AspNetCore.Mvc;
using UserInfoApi.Models;
using UserInfoApi.Services;

namespace UserInfoApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        private IUserInfo _userInfoService;
        public UsersController(IUserInfo userInfoService)
        {
            this._userInfoService = userInfoService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult GetUsers()
        {
            //Added comments...
            return Ok(_userInfoService.GetAllUsers());
        }
        [HttpGet]
        [Route("api/[controller]/{Id}")]
        public ActionResult GetAllUsers(int Id)
        {
            //Added comments from local branch
            return Ok(_userInfoService.GetAllUsers());
        }
        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult AddUser(UserDetails userInfo)
        {
            return Ok(_userInfoService.AddUser(userInfo));
        }
    }
}
