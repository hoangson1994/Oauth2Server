using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oauth2Server.Models
{
    public class AvailabelScopes
    {
        public static Dictionary<string, Oauth2Scope> Items = new Dictionary<string, Oauth2Scope>()
        {
            {
                "http://basicscope.com",
                 new Oauth2Scope()
                {
                    Url = "http://basicscope.com",
                    Name = "Basic",
                    Icon = "https://dw4i9za0jmiyk.cloudfront.net/2016/12/16/news_kcfe726345d7e4c71c9b0e01fa621e40_8fc8e4328c96.png",
                    Description = "Manager your basic information include personal information."
                }
            },
            {
                "http://songresourcescope.com",
                new Oauth2Scope()
                {
                    Url = "http://songresourcescope.com",
                    Name = "Song Resources",
                    Icon = "http://icons.iconarchive.com/icons/kyo-tux/aeon/256/Sign-Music-icon.png",
                    Description = "Manager your song information include upload and get list."
                }
            }
        };

        public static Dictionary<string, Oauth2Scope> GetOauth2Scopes(string scopes)
        {
            Dictionary<string, Oauth2Scope> returnScopes = new Dictionary<string, Oauth2Scope>();
            string[] arrayScopes = scopes.Split(",");
            return returnScopes;
        }
    }
}
