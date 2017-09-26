// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Search.EntitySearch.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Search;
    using Microsoft.CognitiveServices.Search.EntitySearch;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EntityScenario.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityScenario
    {
        [EnumMember(Value = "DominantEntity")]
        DominantEntity,
        [EnumMember(Value = "DisambiguationItem")]
        DisambiguationItem,
        [EnumMember(Value = "ListItem")]
        ListItem
    }
    internal static class EntityScenarioEnumExtension
    {
        internal static string ToSerializedValue(this EntityScenario? value)  =>
            value == null ? null : ((EntityScenario)value).ToSerializedValue();

        internal static string ToSerializedValue(this EntityScenario value)
        {
            switch( value )
            {
                case EntityScenario.DominantEntity:
                    return "DominantEntity";
                case EntityScenario.DisambiguationItem:
                    return "DisambiguationItem";
                case EntityScenario.ListItem:
                    return "ListItem";
            }
            return null;
        }

        internal static EntityScenario? ParseEntityScenario(this string value)
        {
            switch( value )
            {
                case "DominantEntity":
                    return EntityScenario.DominantEntity;
                case "DisambiguationItem":
                    return EntityScenario.DisambiguationItem;
                case "ListItem":
                    return EntityScenario.ListItem;
            }
            return null;
        }
    }
}