﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OpenShift.DotNet.Service.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// StatefulSetUpdateStrategy indicates the strategy that the StatefulSet
    /// controller will use to perform updates. It includes any additional
    /// parameters necessary to perform the update for the indicated strategy.
    /// </summary>
    public partial class Iok8sapiappsv1beta2StatefulSetUpdateStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2StatefulSetUpdateStrategy class.
        /// </summary>
        public Iok8sapiappsv1beta2StatefulSetUpdateStrategy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2StatefulSetUpdateStrategy class.
        /// </summary>
        public Iok8sapiappsv1beta2StatefulSetUpdateStrategy(Iok8sapiappsv1beta2RollingUpdateStatefulSetStrategy rollingUpdate = default(Iok8sapiappsv1beta2RollingUpdateStatefulSetStrategy), string type = default(string))
        {
            RollingUpdate = rollingUpdate;
            Type = type;
        }

        /// <summary>
        /// RollingUpdate is used to communicate parameters when Type is
        /// RollingUpdateStatefulSetStrategyType.
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public Iok8sapiappsv1beta2RollingUpdateStatefulSetStrategy RollingUpdate { get; set; }

        /// <summary>
        /// Type indicates the type of the StatefulSetUpdateStrategy. Default
        /// is RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}