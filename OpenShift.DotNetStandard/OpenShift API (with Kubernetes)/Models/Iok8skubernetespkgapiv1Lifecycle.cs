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
    /// Lifecycle describes actions that the management system should take in
    /// response to container lifecycle events. For the PostStart and PreStop
    /// lifecycle handlers, management of the container blocks until the
    /// action is complete, unless the container process fails, in which case
    /// the handler is aborted.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1Lifecycle
    {
        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1Lifecycle
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1Lifecycle() { }

        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1Lifecycle
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1Lifecycle(Iok8skubernetespkgapiv1Handler postStart = default(Iok8skubernetespkgapiv1Handler), Iok8skubernetespkgapiv1Handler preStop = default(Iok8skubernetespkgapiv1Handler))
        {
            PostStart = postStart;
            PreStop = preStop;
        }

        /// <summary>
        /// PostStart is called immediately after a container is created. If
        /// the handler fails, the container is terminated and restarted
        /// according to its restart policy. Other management of the
        /// container blocks until the hook completes. More info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [JsonProperty(PropertyName = "postStart")]
        public Iok8skubernetespkgapiv1Handler PostStart { get; set; }

        /// <summary>
        /// PreStop is called immediately before a container is terminated.
        /// The container is terminated after the handler completes. The
        /// reason for termination is passed to the handler. Regardless of
        /// the outcome of the handler, the container is eventually
        /// terminated. Other management of the container blocks until the
        /// hook completes. More info:
        /// https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [JsonProperty(PropertyName = "preStop")]
        public Iok8skubernetespkgapiv1Handler PreStop { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.PostStart != null)
            {
                this.PostStart.Validate();
            }
            if (this.PreStop != null)
            {
                this.PreStop.Validate();
            }
        }
    }
}