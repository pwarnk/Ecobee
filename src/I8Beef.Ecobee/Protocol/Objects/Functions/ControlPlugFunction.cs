﻿using I8Beef.Ecobee.Protocol.Objects;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Functions
{
    [DataContract]
    [KnownType(typeof(ControlPlugParams))]
    public class ControlPlugFunction : Function
    {
        public ControlPlugFunction()
        {
            Params = new ControlPlugParams();
        }

        /// <summary>
        /// The function type name. See the type name in the function documentation.
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get { return "controlPlug"; } set { } }

        /// <summary>
        /// A map of key=value pairs as the parameters to the function. See 
        /// individual function documentation for the properties.
        /// </summary>
        [DataMember(Name = "params")]
        public override FunctionParams Params { get; set; }
    }

    [DataContract]
    public class ControlPlugParams : FunctionParams
    {
        /// <summary>
        /// The name of the plug. Ensure each plug has a unique name.
        /// </summary>
        [DataMember(Name = "plugName")]
        public string PlugName { get; set; }

        /// <summary>
        /// The state to put the plug into. Valid values: on, off, resume.
        /// </summary>
        [DataMember(Name = "plugState")]
        public string PlugState { get; set; }

        /// <summary>
        /// The start date in thermostat time.
        /// </summary>
        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// The start time in thermostat time.
        /// </summary>
        [DataMember(Name = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end date in thermostat time.
        /// </summary>
        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// The end time in thermostat time.
        /// </summary>
        [DataMember(Name = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The hold duration type. Valid values: dateTime, nextTransition, indefinite, holdHours.
        /// </summary>
        [DataMember(Name = "holdType")]
        public string HoldType { get; set; }

        /// <summary>
        /// The number of hours to hold for, used and required if holdType='holdHours'.
        /// </summary>
        [DataMember(Name = "holdHours")]
        public int HoldHours { get; set; }
    }
}
