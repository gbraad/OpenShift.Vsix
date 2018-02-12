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
    /// LocalObjectReference contains enough information to let you locate the
    /// referenced object inside the same namespace.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1LocalObjectReference
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LocalObjectReference class.
        /// </summary>
        public Iok8skubernetespkgapiv1LocalObjectReference() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LocalObjectReference class.
        /// </summary>
        public Iok8skubernetespkgapiv1LocalObjectReference(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}