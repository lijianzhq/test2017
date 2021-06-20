using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using JWTTest1.Models;

namespace JWTTest1.AuthAttributes
{
    /// <summary>
    /// 身份认证拦截器
    /// </summary>
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 指示指定的控件是否已获得授权
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //前端请求api时会将token存放在名为"auth"的请求头中
            var authHeader = from t in actionContext.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();
            if (authHeader != null)
            {
                const string secretKey = "Hello World";//加密秘钥
                string token = authHeader.FirstOrDefault();//获取token
                if (!string.IsNullOrEmpty(token))
                {
                    try
                    {
                        byte[] key = Encoding.UTF8.GetBytes(secretKey);
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                        HMACSHAAlgorithmFactory algorithmFactory = new HMACSHAAlgorithmFactory();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithmFactory);
                        //解密
                        var json = decoder.DecodeToObject<AuthInfo>(token, key, verify: true);
                        if (json != null)
                        {
                            //判断口令过期时间
                            if (json.ExpiryDateTime < DateTime.Now)
                            {
                                return false;
                            }
                            actionContext.RequestContext.RouteData.Values.Add("auth", json);
                            return true;
                        }
                        return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 处理授权失败的请求
        /// </summary>
        /// <param name="actionContext"></param>
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var erModel = new
            {
                Success = "false",
                ErrorCode = "401"
            };
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, erModel, "application/json");
        }

        /// <summary>
        ///  为操作授权时调用
        /// </summary>
        /// <param name="actionContext"></param>
        //public override void OnAuthorization(HttpActionContext actionContext)
        //{

        //}
    }
}
