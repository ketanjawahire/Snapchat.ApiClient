using Snapchat.ApiClient;
using System;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiServices = new SnapchatServices("client_Id", "client_secret", "refresh_token");

            var organizationService = apiServices.GetService<IOrganizationService>();
            var accountService = apiServices.GetService<IAdAccountService>();
            var campaignService = apiServices.GetService<ICampaignService>();
        }
    }
}
