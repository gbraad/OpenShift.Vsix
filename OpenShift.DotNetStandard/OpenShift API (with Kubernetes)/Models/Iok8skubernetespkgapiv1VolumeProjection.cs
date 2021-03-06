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
    /// Projection that may be projected along with other supported volume
    /// types
    /// </summary>
    public partial class Iok8skubernetespkgapiv1VolumeProjection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1VolumeProjection class.
        /// </summary>
        public Iok8skubernetespkgapiv1VolumeProjection() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1VolumeProjection class.
        /// </summary>
        public Iok8skubernetespkgapiv1VolumeProjection(Iok8skubernetespkgapiv1ConfigMapProjection configMap = default(Iok8skubernetespkgapiv1ConfigMapProjection), Iok8skubernetespkgapiv1DownwardAPIProjection downwardAPI = default(Iok8skubernetespkgapiv1DownwardAPIProjection), Iok8skubernetespkgapiv1SecretProjection secret = default(Iok8skubernetespkgapiv1SecretProjection))
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
        }

        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        [JsonProperty(PropertyName = "configMap")]
        public Iok8skubernetespkgapiv1ConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        [JsonProperty(PropertyName = "downwardAPI")]
        public Iok8skubernetespkgapiv1DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>
        /// information about the secret data to project
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Iok8skubernetespkgapiv1SecretProjection Secret { get; set; }

    }
}
