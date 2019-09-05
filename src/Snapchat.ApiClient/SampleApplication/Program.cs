using Snapchat.ApiClient.Services;
using Snapchat.ApiClient.Services.Interfaces;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize snapchat service with client id, client secret & refresh token. 
            var snapchatServices = new SnapchatServices("clientId", "clientSecret", "refreshToken");

            //Get services to interact with ad account object
            var accountService = snapchatServices.GetService<IAdAccountService>();
            var adAccount = accountService.GetByAccountId("accountId");

            //Get services to interact with ad object
            var adService = snapchatServices.GetService<IAdService>();
            var ad = adService.Get("adId");

            //Get services to interact with campaign object
            var campaignService = snapchatServices.GetService<ICampaignService>();
            var campaign = campaignService.GetById("campaignId");

            //Get services to interact with ad squad object
            var adSquadService = snapchatServices.GetService<IAdSquadService>();
            var adSquad = adSquadService.Get("adSquadId");

            //Get services to interact with creative object
            var creativeService = snapchatServices.GetService<ICreativeService>();
            var creative = creativeService.Get("creativeId");

            //Get services to interact with organization object
            var organizationService = snapchatServices.GetService<IOrganizationService>();
            var organization = organizationService.GetById("organizationId");
        }
    }
}
