using System;
using Newtonsoft.Json;

namespace Snapchat.ApiClient.Entities.Api
{
    /// <summary>
    /// Represents Snapchat organization.
    /// </summary>
    public class Organization : IEntity
    {
        /// <summary>
        /// Gets or sets organization id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets updated at time.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets created at time.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets organization name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets address line 1.
        /// </summary>
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets locality.
        /// </summary>
        [JsonProperty("locality")]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets administrative disctrict level 1.
        /// </summary>
        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets organization type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
