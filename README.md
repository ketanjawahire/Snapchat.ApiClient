# Snapchat.ApiClient

A C# SDK for Snapchat Marketing API. The Snapchat SDK for .NET helps developers build applications interacting with Snapchat Marketing API. This project aims to help developers working with Snapchat marketing API. Snapchat supports REST API endpoints to interact with core object models. This SDK will help you in doing various API calls & converting API response into structured response.

## Nuget [![NuGet](https://img.shields.io/nuget/v/Snapchat.ApiClient.svg?maxAge=25000)](http://www.nuget.org/packages/Snapchat.ApiClient/) [![Nuget](https://img.shields.io/nuget/dt/Snapchat.ApiClient.svg?maxAge=25000)](https://www.nuget.org/packages/Snapchat.ApiClient/)

```    
	Install-Package Snapchat.ApiClient
```

## Code Example
Here is a short version of how to use this SDK. For more details check SampleApplication.

```C#
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
```	

---

# List of Services 

## `IAdAccountService`

Provides methods to do ad account level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IAdAccountService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Adaccount` | GetByAccountId(`String` accountId) | Gets ad account by id. | 
| `IEnumerable<Adaccount>` | GetByOrganizationId(`String` organizationId, `PagingOption` pagingOption) | Gets all ad accounts for given organization id. | 


## `IAdService`

Provides methods to do ad level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IAdService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Ad` | Get(`String` id) | Gets ad by id. | 
| `IEnumerable<Ad>` | GetByAdAccountId(`String` id, `PagingOption` pagingOption) | Gets all ads under given ad account. | 
| `IEnumerable<Ad>` | GetByAdSquadId(`String` id, `PagingOption` pagingOption) | Gets all ads for given ad sqad. | 


## `IAdSquadService`

Provides methods to do ad squad level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IAdSquadService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Adsquad` | Get(`String` adsquaqId) | Gets ad squad by id. | 
| `IEnumerable<Adsquad>` | GetByAdAccountId(`String` id, `PagingOption` pagingOption) | Gets all ad squads for given ad account. | 
| `IEnumerable<Adsquad>` | GetByCampaignId(`String` id, `PagingOption` pagingOption) | Gets all ad squads for given campaign. | 


## `IApiService`

Represents base interface for any Snapchat API service.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IApiService

```

## `ICampaignService`

Provides methods to do campaign level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.ICampaignService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<Campaign>` | GetByAccountId(`String` id, `PagingOption` pagingOption) | Gets campaigns under given ad account. | 
| `Campaign` | GetById(`String` campaignId) | Gets campaigns by id. | 


## `ICreativeService`

Provides methods to do cretive level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.ICreativeService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Creative` | Get(`String` creativeId) | Gets creative by id. | 
| `IEnumerable<Creative>` | GetByAdAccountId(`String` id, `PagingOption` pagingOption) | Gets creatives under given ad account. | 


## `IMeasurementService`

Provides methods to get measurement data using Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IMeasurementService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `T` | GetStats(`String` entityId, `StatsOptions` options) | Gets measurement data for given entity id using given stat options. | 


## `IOrganizationService`

Provides methods to do organization level operation on Snapchat API.
```csharp
public interface Snapchat.ApiClient.Services.Interfaces.IOrganizationService
    : IApiService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<Organization>` | Get(`PagingOption` pagingOption) | Gets all organization for given user. | 
| `Organization` | GetById(`String` organizationId) | Gets organization by id. | 



---


# API Entity References

## `Ad`

Represents Snapchat Ad entity.
```csharp
public class Snapchat.ApiClient.Entities.Api.Ad
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AdSquadId | Gets or Sets AdSquad Id. | 
| `DateTime` | CreatedAt | Gets or Sets Ad created time. | 
| `String` | CreativeId | Gets or Sets Ad creative id. | 
| `String` | Id | Gets or Sets Ad Id. | 
| `String` | Name | Gets or Sets Ad name. | 
| `AdReviewStatus` | ReviewStatus | Gets or sets ad review status. | 
| `List<String>` | ReviewStatusReasons | Gets or sets ad review reasons. | 
| `AdStatus` | Status | Gets or sets As status. | 
| `AdType` | Type | Gets or sets ad type. | 
| `DateTime` | UpdatedAt | Gets or Sets Ad Updated at value. | 


## `Adaccount`

Represents Snapchat ad account.
```csharp
public class Snapchat.ApiClient.Entities.Api.Adaccount
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Advertiser | Gets or sets advertiser. | 
| `DateTime` | CreatedAt | Gets or sets created at value. | 
| `String` | Currency | Gets or sets currency. | 
| `List<String>` | FundingSourceIds | Gets or sets funding source ids. | 
| `String` | Id | Gets or sets ad account id. | 
| `String` | Name | Gets or sets ad account name. | 
| `String` | OrganizationId | Gets or sets organization id. | 
| `String` | Status | Gets or sets ad account status. | 
| `String` | Timezone | Gets or sets timezone. | 
| `AdAccountType` | Type | Gets or sets ad account type. | 
| `DateTime` | UpdatedAt | Gets or sets updated at value. | 


## `Adsquad`

Represents Snapchat Adsquad entity.
```csharp
public class Snapchat.ApiClient.Entities.Api.Adsquad
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Int64` | BidMicro | Gets or sets max bid. | 
| `String` | BillingEvent | Gets or sets billing event information. | 
| `String` | CampaignId | Gets or sets campaign id. | 
| `DateTime` | CreatedAt | Gets or sets created at value. | 
| `Int64` | DailyBudgetMicro | Gets or sets daily budget. | 
| `String` | Id | Gets or sets Adsquad id. | 
| `String` | Name | Gets or sets adsquad name. | 
| `OptimizationGoal` | OptimizationGoal | Gets or sets optimization goal. | 
| `String` | Placement | Gets or sets adsquad placement. | 
| `DateTime` | StartTime | Gets or sets start time. | 
| `String` | Status | Gets or sets adsquad status. | 
| `Targeting` | Targeting | Gets or sets adsquad targeting. | 
| `String` | Type | Gets or sets adsquad type. | 
| `DateTime` | UpdatedAt | Gets or sets updated at value. | 


## `AppInstallProperties`

Reprresents Snapchat app install properties.
```csharp
public class Snapchat.ApiClient.Entities.Api.AppInstallProperties

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AndroidAppUrl | Gets or sets andriod app url. | 
| `String` | AppName | Gets or sets app name. | 
| `String` | IconMediaId | Gets or sets icon media id. | 
| `String` | IosAppId | Gets or sets iOS app id. | 


## `AuthResponse`

Represents Snapchat authentication api call response.
```csharp
public class Snapchat.ApiClient.Entities.Api.AuthResponse

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AccessToken | Gets or sets access token. | 
| `Int64` | ExpiresIn | Gets or sets token expiration time. | 
| `String` | RefreshToken | Gets or sets refresh token. | 
| `String` | Scope | Gets or sets token scope. | 
| `String` | TokenType | Gets or sets token type. | 


## `Campaign`

Represents Snapchat campaign entity.
```csharp
public class Snapchat.ApiClient.Entities.Api.Campaign
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AdAccountId | Gets or sets ad account id. | 
| `DateTime` | CreatedAt | Gets or sets created at value. | 
| `Nullable<Int64>` | DailyBudgetMicro | Gets or sets daily budget value. | 
| `Nullable<DateTime>` | EndTime | Gets or sets end time. | 
| `String` | Id | Gets or sets campaign id. | 
| `Nullable<Int64>` | LifetimeSpendCapMicro | Gets or sets Lifetime spend cap for the campaign. | 
| `String` | Name | Gets or sets campaign name. | 
| `String` | Objective | Gets or sets campaign objective. | 
| `DateTime` | StartTime | Gets or sets start time. | 
| `CampaignStatus` | Status | Gets or sets status. | 
| `DateTime` | UpdatedAt | Gets or sets updated at value. | 


## `Creative`

Represents Snapchat creative.
```csharp
public class Snapchat.ApiClient.Entities.Api.Creative
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AdAccountId | Gets or sets ad account id. | 
| `AppInstallProperties` | AppInstallProperties | Gets or sets app install properties. | 
| `CallToAction` | CallToAction | Gets or sets call to action type. | 
| `DateTime` | CreatedAt | Gets or sets created at time. | 
| `String` | Headline | Gets or sets creative headline. | 
| `String` | Id | Gets or sets creative id. | 
| `LongformVideoProperties` | LongformVideoProperties | Gets or sets long form video properties. | 
| `String` | Name | Gets or sets creative name. | 
| `String` | PackagingStatus | Gets or sets packaging status. | 
| `String` | ReviewStatus | Gets or sets review status. | 
| `Boolean` | Shareable | Gets or sets a value indicating whether it is sharable or not. | 
| `Nullable<TopSnapCropPosition>` | TopSnapCropPosition | Gets or sets top snap crop position. | 
| `String` | TopSnapMediaId | Gets or sets top snap id. | 
| `CreativeType` | Type | Gets or sets creative type. | 
| `DateTime` | UpdatedAt | Gets or sets updated at time. | 
| `WebViewProperties` | WebViewProperties | Gets or sets web view properties. | 


## `Geo`

Represents Snapchat Geo entity.
```csharp
public class Snapchat.ApiClient.Entities.Api.Geo

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | CountryCode | Gets or sets country code. | 


## `LongformVideoProperties`

Represents Snapchat long form video properties.
```csharp
public class Snapchat.ApiClient.Entities.Api.LongformVideoProperties

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | VideoMediaId | Gets or sets video media id. | 


## `Organization`

Represents Snapchat organization.
```csharp
public class Snapchat.ApiClient.Entities.Api.Organization
    : IEntity

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AddressLine1 | Gets or sets address line 1. | 
| `String` | AdministrativeDistrictLevel1 | Gets or sets administrative disctrict level 1. | 
| `String` | Country | Gets or sets country. | 
| `DateTime` | CreatedAt | Gets or sets created at time. | 
| `String` | Id | Gets or sets organization id. | 
| `String` | Locality | Gets or sets locality. | 
| `String` | Name | Gets or sets organization name. | 
| `String` | PostalCode | Gets or sets postal code. | 
| `String` | Type | Gets or sets organization type. | 
| `DateTime` | UpdatedAt | Gets or sets updated at time. | 


## `Paging`

Represents Snapchat paging object.
```csharp
public class Snapchat.ApiClient.Entities.Api.Paging

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | NextLink | Gets or sets next page link. | 


## `Targeting`

Represents Snapchat targeting.
```csharp
public class Snapchat.ApiClient.Entities.Api.Targeting

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `List<Geo>` | Geos | Gets or sets geos. | 


## `WebViewProperties`

Represents Snapchat web view properties.
```csharp
public class Snapchat.ApiClient.Entities.Api.WebViewProperties

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Url | Gets or sets url. | 


---


# Supported Platforms
* .NET 4.5.2
* .NETStandard 2.0