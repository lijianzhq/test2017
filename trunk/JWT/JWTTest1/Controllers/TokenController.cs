using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using JWTTest1.Models;

namespace JWTTest1.Controllers
{
    [RoutePrefix("api/Token")]
    public class TokenController : ApiController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public TokenInfo Login([FromBody] LoginRequest loginRequest)
        {
            TokenInfo tokenInfo = new TokenInfo();//需要返回的口令信息
            if (loginRequest != null)
            {
                string userName = loginRequest.UserName;
                string passWord = loginRequest.Password;
                bool isAdmin = (userName == "admin") ? true : false;
                //模拟数据库数据，真正的数据应该从数据库读取
                //身份验证信息
                AuthInfo authInfo = new AuthInfo { UserName = userName, Roles = new List<string> { "admin", "commonrole" }, IsAdmin = isAdmin, ExpiryDateTime = DateTime.Now.AddHours(2) };
                const string secretKey = "Hello World";//口令加密秘钥
                try
                {
                    byte[] key = Encoding.UTF8.GetBytes(secretKey);
                    IJwtAlgorithm algorithm = new HMACSHA256Algorithm();//加密方式
                    IJsonSerializer serializer = new JsonNetSerializer();//序列化Json
                    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//base64加解密
                    IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);//JWT编码
                    var token = encoder.Encode(authInfo, key);//生成令牌
                    //口令信息
                    tokenInfo.Success = true;
                    tokenInfo.Token = token;
                    tokenInfo.Message = "OK";
                }
                catch (Exception ex)
                {
                    tokenInfo.Success = false;
                    tokenInfo.Message = ex.Message.ToString();
                }
            }
            else
            {
                tokenInfo.Success = false;
                tokenInfo.Message = "用户信息为空";
            }
            return tokenInfo;
        }
    }
}
