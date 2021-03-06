// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dto with attributes required for Wait activity
    /// </summary>
    public partial class TaskDataDto
    {
        /// <summary>
        /// Initializes a new instance of the TaskDataDto class.
        /// </summary>
        public TaskDataDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskDataDto class.
        /// </summary>
        /// <param name="status">Task status. Possible values include:
        /// 'Unassigned', 'Pending', 'Completed'</param>
        /// <param name="data">Task form data json</param>
        /// <param name="action">Task form action</param>
        public TaskDataDto(TaskDataDtoStatus? status = default(TaskDataDtoStatus?), object data = default(object), string action = default(string), long? id = default(long?))
        {
            Status = status;
            Data = data;
            Action = action;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets task status. Possible values include: 'Unassigned',
        /// 'Pending', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TaskDataDtoStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets task form data json
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets task form action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

    }
}
