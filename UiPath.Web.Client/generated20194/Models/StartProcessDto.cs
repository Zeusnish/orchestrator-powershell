// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Start Process transfers information from client to the server
    /// during JobsController.StartJobs custom action.
    /// </summary>
    public partial class StartProcessDto
    {
        /// <summary>
        /// Initializes a new instance of the StartProcessDto class.
        /// </summary>
        public StartProcessDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartProcessDto class.
        /// </summary>
        /// <param name="releaseKey">The unique key of the release associated
        /// with the process.</param>
        /// <param name="strategy">States which robots from the environment are
        /// being run by the process. Possible values include: 'All',
        /// 'Specific', 'RobotCount', 'JobsCount'</param>
        /// <param name="robotIds">The collection of ids of specific robots
        /// selected to be run by the current process. This collection must be
        /// empty only if the start strategy is not Specific.</param>
        /// <param name="noOfRobots">DEPRECATED. Number of pending jobs to be
        /// created in the environment, for the current process. This number
        /// must be greater than 0 only if the start strategy is
        /// RobotCount.</param>
        /// <param name="jobsCount">Number of pending jobs to be created in the
        /// environment, for the current process. This number must be greater
        /// than 0 only if the start strategy is JobsCount.</param>
        /// <param name="source">The Source of the job starting the current
        /// process. Possible values include: 'Manual', 'Schedule'</param>
        /// <param name="inputArguments">Input parameters in JSON format to be
        /// passed to job execution.</param>
        public StartProcessDto(string releaseKey, StartProcessDtoStrategy? strategy = default(StartProcessDtoStrategy?), IList<long?> robotIds = default(IList<long?>), int? noOfRobots = default(int?), int? jobsCount = default(int?), StartProcessDtoSource? source = default(StartProcessDtoSource?), string inputArguments = default(string))
        {
            ReleaseKey = releaseKey;
            Strategy = strategy;
            RobotIds = robotIds;
            NoOfRobots = noOfRobots;
            JobsCount = jobsCount;
            Source = source;
            InputArguments = inputArguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique key of the release associated with the
        /// process.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseKey")]
        public string ReleaseKey { get; set; }

        /// <summary>
        /// Gets or sets states which robots from the environment are being run
        /// by the process. Possible values include: 'All', 'Specific',
        /// 'RobotCount', 'JobsCount'
        /// </summary>
        [JsonProperty(PropertyName = "Strategy")]
        public StartProcessDtoStrategy? Strategy { get; set; }

        /// <summary>
        /// Gets or sets the collection of ids of specific robots selected to
        /// be run by the current process. This collection must be empty only
        /// if the start strategy is not Specific.
        /// </summary>
        [JsonProperty(PropertyName = "RobotIds")]
        public IList<long?> RobotIds { get; set; }

        /// <summary>
        /// Gets or sets DEPRECATED. Number of pending jobs to be created in
        /// the environment, for the current process. This number must be
        /// greater than 0 only if the start strategy is RobotCount.
        /// </summary>
        [JsonProperty(PropertyName = "NoOfRobots")]
        [System.Obsolete("This property is deprecated. Please do not use it any longer.")]
        public int? NoOfRobots { get; set; }

        /// <summary>
        /// Gets or sets number of pending jobs to be created in the
        /// environment, for the current process. This number must be greater
        /// than 0 only if the start strategy is JobsCount.
        /// </summary>
        [JsonProperty(PropertyName = "JobsCount")]
        public int? JobsCount { get; set; }

        /// <summary>
        /// Gets or sets the Source of the job starting the current process.
        /// Possible values include: 'Manual', 'Schedule'
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public StartProcessDtoSource? Source { get; set; }

        /// <summary>
        /// Gets or sets input parameters in JSON format to be passed to job
        /// execution.
        /// </summary>
        [JsonProperty(PropertyName = "InputArguments")]
        public string InputArguments { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReleaseKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReleaseKey");
            }
        }
    }
}