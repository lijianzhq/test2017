using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTTest1.AuthAttributes;
using Newtonsoft.Json;
using System.Web.Http;

namespace JWTTest1.Controllers
{
    [RoutePrefix("api/UserInfo")]
    public class UserInfoController : ApiController
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserInfo")]
        public string GetUserInfo()
        {
            var userInfo = new
            {
                UserName = "test",
                Tel = "123456789",
                Address = "testddd"
            };
            return JsonConvert.SerializeObject(userInfo);
        }       
    }
}
