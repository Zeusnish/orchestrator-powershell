// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookTaskAssignmentChangedDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTaskAssignmentChangedDtoStatus
    {
        [EnumMember(Value = "Unassigned")]
        Unassigned,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class WebhookTaskAssignmentChangedDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this WebhookTaskAssignmentChangedDtoStatus? value)
        {
            return value == null ? null : ((WebhookTaskAssignmentChangedDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookTaskAssignmentChangedDtoStatus value)
        {
            switch( value )
            {
                case WebhookTaskAssignmentChangedDtoStatus.Unassigned:
                    return "Unassigned";
                case WebhookTaskAssignmentChangedDtoStatus.Pending:
                    return "Pending";
                case WebhookTaskAssignmentChangedDtoStatus.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static WebhookTaskAssignmentChangedDtoStatus? ParseWebhookTaskAssignmentChangedDtoStatus(this string value)
        {
            switch( value )
            {
                case "Unassigned":
                    return WebhookTaskAssignmentChangedDtoStatus.Unassigned;
                case "Pending":
                    return WebhookTaskAssignmentChangedDtoStatus.Pending;
                case "Completed":
                    return WebhookTaskAssignmentChangedDtoStatus.Completed;
            }
            return null;
        }
    }
}
