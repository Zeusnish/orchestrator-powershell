// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConfigurationEntry
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationEntry class.
        /// </summary>
        public ConfigurationEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationEntry class.
        /// </summary>
        /// <param name="valueType">Possible values include: 'String',
        /// 'Number', 'Choice', 'Boolean', 'Section'</param>
        public ConfigurationEntry(string key = default(string), string displayName = default(string), ConfigurationEntryValueType? valueType = default(ConfigurationEntryValueType?))
        {
            Key = key;
            DisplayName = displayName;
            ValueType = valueType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'String', 'Number', 'Choice',
        /// 'Boolean', 'Section'
        /// </summary>
        [JsonProperty(PropertyName = "ValueType")]
        public ConfigurationEntryValueType? ValueType { get; set; }

    }
}