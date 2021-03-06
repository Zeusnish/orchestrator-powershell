// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TestJobDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TestJobDtoState
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopping")]
        Stopping,
        [EnumMember(Value = "Terminating")]
        Terminating,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Stopped")]
        Stopped,
        [EnumMember(Value = "Suspended")]
        Suspended,
        [EnumMember(Value = "Resumed")]
        Resumed
    }
    internal static class TestJobDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this TestJobDtoState? value)
        {
            return value == null ? null : ((TestJobDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TestJobDtoState value)
        {
            switch( value )
            {
                case TestJobDtoState.Pending:
                    return "Pending";
                case TestJobDtoState.Running:
                    return "Running";
                case TestJobDtoState.Stopping:
                    return "Stopping";
                case TestJobDtoState.Terminating:
                    return "Terminating";
                case TestJobDtoState.Faulted:
                    return "Faulted";
                case TestJobDtoState.Successful:
                    return "Successful";
                case TestJobDtoState.Stopped:
                    return "Stopped";
                case TestJobDtoState.Suspended:
                    return "Suspended";
                case TestJobDtoState.Resumed:
                    return "Resumed";
            }
            return null;
        }

        internal static TestJobDtoState? ParseTestJobDtoState(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return TestJobDtoState.Pending;
                case "Running":
                    return TestJobDtoState.Running;
                case "Stopping":
                    return TestJobDtoState.Stopping;
                case "Terminating":
                    return TestJobDtoState.Terminating;
                case "Faulted":
                    return TestJobDtoState.Faulted;
                case "Successful":
                    return TestJobDtoState.Successful;
                case "Stopped":
                    return TestJobDtoState.Stopped;
                case "Suspended":
                    return TestJobDtoState.Suspended;
                case "Resumed":
                    return TestJobDtoState.Resumed;
            }
            return null;
        }
    }
}
