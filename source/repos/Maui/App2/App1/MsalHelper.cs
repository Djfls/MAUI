using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class MsalHelper
    {
        private static IPublicClientApplication instance;
        static MsalHelper() 
        {
            _msalPublicClientApp = PublicClientApplicationBuilder
                .Create(Repository.Constants.AccountClientId)
                .WithAuthority(AadAuthorityAudience.AzureAdMultipleOrgs)
                .WithDefaultRedirectUri()
                .Build();

            Task.Run(ConfigureCachingAsync);
        }

        private static void ConfigureCachingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
