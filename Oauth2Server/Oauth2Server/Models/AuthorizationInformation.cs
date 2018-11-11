using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oauth2Server.Controllers;

namespace Oauth2Server.Models
{
    [NotMapped]
    public class AuthorizationInformation
    {
        public RegisteredClient RegisteredClient { get; set; }
        public Dictionary<string, Oauth2Scope> Oauth2Scopes { get; set; }
    }
    
}