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
    /// BuildStatusOutput contains the status of the built image.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutput
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutput
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutput(Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutputTo to = default(Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutputTo))
        {
            To = to;
        }

        /// <summary>
        /// to describes the status of the built image being pushed to a
        /// registry.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public Comgithubopenshiftoriginpkgbuildapisbuildv1BuildStatusOutputTo To { get; set; }

    }
}