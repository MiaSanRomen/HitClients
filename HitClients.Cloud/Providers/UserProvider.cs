using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HitClients.Cloud.Providers
{
    public class UserProvider
    {
        public static SignInStatus CheckUser(string login, string password)
        {
            if(login == "romanwt@mail.ru" && password == "Rr")
            {
                return SignInStatus.Success;
            }
            return SignInStatus.Failure;
        }
    }
}