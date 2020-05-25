using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using AddressFormattingDotNet.Enums;
using AddressFormattingDotNet.Helpers;
using AddressFormattingDotNet.Models;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace AddressFormattingDotNet
{
    public class AddressFormatting
    {
        private const string AddressFormattingDataDirectory =
            "C:\\Projects\\AddressFormattingDotNet\\AddressFormattingDotNet\\AddressFormattingData\\conf\\";

        public List<KeyValuePair<string, Components>> _componentMapping;

        public AddressFormatting()
        {

        }

        public void LoadTemplates()
        {

        }

        public void LoadComponentAliases()
        {
            var componentFilename = $"{AddressFormattingDataDirectory}components.yaml";
            var components = YamlHelper.DeserializeListFromFilePath<ComponentStructure>(componentFilename);
            var componentMapping = new List<KeyValuePair<string, Components>>();

            foreach (var component in components)
            {
                var componentEnum = MapComponent(component.Name);

                componentMapping.Add(new KeyValuePair<string, Components>(component.Name, componentEnum));
                if (component.Aliases?.Count > 0)
                {
                    foreach (var alias in component.Aliases)
                    {
                        componentMapping.Add(new KeyValuePair<string, Components>(alias, componentEnum));
                    }
                }
            }

            _componentMapping = componentMapping;
        }

        private Components MapComponent(string yamlMember)
        {
            return (yamlMember switch
            {
                "house_number" => Components.HouseNumber,
                "house" => Components.House,
                "road" => Components.Road,
                "village" => Components.Village,
                "neighbourhood" => Components.Neighbourhood,
                "neighborhood" => Components.Neighbourhood,
                "city" => Components.City,
                "county" => Components.County,
                "state_district" => Components.StateDistrict,
                "postcode" => Components.Postcode,
                "state" => Components.State,
                "region" => Components.Region,
                "island" => Components.Island,
                "country" => Components.Country,
                "country_code" => Components.CountryCode,
                "continent" => Components.Continent,
                _ => Components.Attention
            });
        }
    }
}
