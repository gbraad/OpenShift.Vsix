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
    /// WebHookTrigger is a trigger that gets invoked using a webhook type of
    /// post
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1WebHookTrigger
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1WebHookTrigger class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1WebHookTrigger() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1WebHookTrigger class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1WebHookTrigger(bool? allowEnv = default(bool?), string secret = default(string))
        {
            AllowEnv = allowEnv;
            Secret = secret;
        }

        /// <summary>
        /// allowEnv determines whether the webhook can set environment
        /// variables; can only be set to true for GenericWebHook.
        /// </summary>
        [JsonProperty(PropertyName = "allowEnv")]
        public bool? AllowEnv { get; set; }

        /// <summary>
        /// secret used to validate requests.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

    }
}