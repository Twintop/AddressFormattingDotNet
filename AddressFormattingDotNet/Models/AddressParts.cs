using YamlDotNet.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AddressFormattingDotNet.Models
{
    public class AddressParts
    {
        [YamlMember(Alias = "attention", ApplyNamingConventions = false)]
        public string Attention { get; set; }

        // These are taken from components.yaml
        [YamlMember(Alias = "house_number", ApplyNamingConventions = false)]
        public string HouseNumber { get; set; }

        [YamlMember(Alias = "house", ApplyNamingConventions = false)]
        public string House { get; set; }

        [YamlMember(Alias = "road", ApplyNamingConventions = false)]
        public string Road { get; set; }

        [YamlMember(Alias = "village", ApplyNamingConventions = false)]
        public string Village { get; set; }

        [YamlMember(Alias = "neighbourhood", ApplyNamingConventions = false)]
        public string NeighbourHood { get; set; }

        [YamlMember(Alias = "city", ApplyNamingConventions = false)]
        public string City { get; set; }

        [YamlMember(Alias = "county", ApplyNamingConventions = false)]
        public string County { get; set; }

        [YamlMember(Alias = "state_district", ApplyNamingConventions = false)]
        public string StateDistrict { get; set; }

        [YamlMember(Alias = "postcode", ApplyNamingConventions = false)]
        public string Postcode { get; set; }

        [YamlMember(Alias = "state", ApplyNamingConventions = false)]
        public string State { get; set; }

        [YamlMember(Alias = "region", ApplyNamingConventions = false)]
        public string Region { get; set; }

        [YamlMember(Alias = "island", ApplyNamingConventions = false)]
        public string Island { get; set; }

        [YamlMember(Alias = "country", ApplyNamingConventions = false)]
        public string Country { get; set; }

        [YamlMember(Alias = "country_code", ApplyNamingConventions = false)]
        public string CountryCode { get; set; }

        [YamlMember(Alias = "continent", ApplyNamingConventions = false)]
        public string Continent { get; set; }
    }
}