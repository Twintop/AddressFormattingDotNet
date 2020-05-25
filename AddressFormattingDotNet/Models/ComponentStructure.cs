using System.Collections.Generic;
using System.ComponentModel;
using YamlDotNet.Serialization;

namespace AddressFormattingDotNet.Models
{
    public class ComponentStructure
    {
        [YamlMember(Alias = "name", ApplyNamingConventions = false)]
        public string Name { get; set; }
        [YamlMember(Alias = "aliases", ApplyNamingConventions = false)]
        public List<string> Aliases { get; set; }
    }
}