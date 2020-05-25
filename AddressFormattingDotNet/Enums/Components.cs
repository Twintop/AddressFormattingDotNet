using System.Diagnostics;
using YamlDotNet.Serialization;

namespace AddressFormattingDotNet.Enums
{
    public enum Components
    {
        [YamlMember(Alias = "house_number", ApplyNamingConventions = false)]
        HouseNumber,
        [YamlMember(Alias = "house", ApplyNamingConventions = false)]
        House,
        [YamlMember(Alias = "road", ApplyNamingConventions = false)]
        Road,
        [YamlMember(Alias = "village", ApplyNamingConventions = false)]
        Village,
        [YamlMember(Alias = "neighbourhood", ApplyNamingConventions = false)]
        Neighbourhood,
        [YamlMember(Alias = "city", ApplyNamingConventions = false)]
        City,
        [YamlMember(Alias = "country", ApplyNamingConventions = false)]
        County,
        [YamlMember(Alias = "state_district", ApplyNamingConventions = false)]
        StateDistrict,
        [YamlMember(Alias = "postcode", ApplyNamingConventions = false)]
        Postcode,
        [YamlMember(Alias = "state", ApplyNamingConventions = false)]
        State,
        [YamlMember(Alias = "region", ApplyNamingConventions = false)]
        Region,
        [YamlMember(Alias = "island", ApplyNamingConventions = false)]
        Island,
        [YamlMember(Alias = "country", ApplyNamingConventions = false)]
        Country,
        [YamlMember(Alias = "country_code", ApplyNamingConventions = false)]
        CountryCode,
        [YamlMember(Alias = "continent", ApplyNamingConventions = false)]
        Continent,
        // This is used for anything that doesn't match 
        [YamlMember(Alias = "attention", ApplyNamingConventions = false)]
        Attention
    }
}