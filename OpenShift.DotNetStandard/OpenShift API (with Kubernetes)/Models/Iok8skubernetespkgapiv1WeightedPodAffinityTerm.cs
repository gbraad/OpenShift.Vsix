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
    /// The weights of all of the matched WeightedPodAffinityTerm fields are
    /// added per-node to find the most preferred node(s)
    /// </summary>
    public partial class Iok8skubernetespkgapiv1WeightedPodAffinityTerm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1WeightedPodAffinityTerm class.
        /// </summary>
        public Iok8skubernetespkgapiv1WeightedPodAffinityTerm() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1WeightedPodAffinityTerm class.
        /// </summary>
        public Iok8skubernetespkgapiv1WeightedPodAffinityTerm(Iok8skubernetespkgapiv1PodAffinityTerm podAffinityTerm, int weight)
        {
            PodAffinityTerm = podAffinityTerm;
            Weight = weight;
        }

        /// <summary>
        /// Required. A pod affinity term, associated with the corresponding
        /// weight.
        /// </summary>
        [JsonProperty(PropertyName = "podAffinityTerm")]
        public Iok8skubernetespkgapiv1PodAffinityTerm PodAffinityTerm { get; set; }

        /// <summary>
        /// weight associated with matching the corresponding podAffinityTerm,
        /// in the range 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (PodAffinityTerm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PodAffinityTerm");
            }
        }
    }
}