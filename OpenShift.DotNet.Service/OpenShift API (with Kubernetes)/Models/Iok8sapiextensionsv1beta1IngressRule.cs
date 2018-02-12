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
    /// IngressRule represents the rules mapping the paths under a specified
    /// host to the related backend services. Incoming requests are first
    /// evaluated for a host match, then routed to the backend associated
    /// with the matching IngressRuleValue.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1IngressRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1IngressRule class.
        /// </summary>
        public Iok8sapiextensionsv1beta1IngressRule() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1IngressRule class.
        /// </summary>
        public Iok8sapiextensionsv1beta1IngressRule(string host = default(string), Iok8sapiextensionsv1beta1HTTPIngressRuleValue http = default(Iok8sapiextensionsv1beta1HTTPIngressRuleValue))
        {
            Host = host;
            Http = http;
        }

        /// <summary>
        /// Host is the fully qualified domain name of a network host, as
        /// defined by RFC 3986. Note the following deviations from the
        /// "host" part of the URI as defined in the RFC: 1. IPs are not
        /// allowed. Currently an IngressRuleValue can only apply to the
        /// IP in the Spec of the parent Ingress.
        /// 2. The `:` delimiter is not respected because ports are not
        /// allowed.
        /// Currently the port of an Ingress is implicitly :80 for http and
        /// :443 for https.
        /// Both these may change in the future. Incoming requests are matched
        /// against the host before the IngressRuleValue. If the host is
        /// unspecified, the Ingress routes all traffic based on the
        /// specified IngressRuleValue.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public Iok8sapiextensionsv1beta1HTTPIngressRuleValue Http { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Http != null)
            {
                this.Http.Validate();
            }
        }
    }
}