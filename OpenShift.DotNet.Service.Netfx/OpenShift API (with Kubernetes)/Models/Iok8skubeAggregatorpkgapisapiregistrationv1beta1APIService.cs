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
    /// APIService represents a server for a particular GroupVersion. Name
    /// must be "version.group".
    /// </summary>
    public partial class Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIService class.
        /// </summary>
        public Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIService() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIService class.
        /// </summary>
        public Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIService(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceSpec spec = default(Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceSpec), Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceStatus status = default(Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec contains information for locating and communicating with a
        /// server
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceSpec Spec { get; set; }

        /// <summary>
        /// Status contains derived information about an API server
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8skubeAggregatorpkgapisapiregistrationv1beta1APIServiceStatus Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.Spec != null)
            {
                this.Spec.Validate();
            }
        }
    }
}