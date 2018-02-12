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
    /// TemplateInstanceSpec describes the desired state of a TemplateInstance.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceSpec(Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceRequester requester, Comgithubopenshiftoriginpkgtemplateapistemplatev1Template template, Iok8skubernetespkgapiv1LocalObjectReference secret = default(Iok8skubernetespkgapiv1LocalObjectReference))
        {
            Requester = requester;
            Secret = secret;
            Template = template;
        }

        /// <summary>
        /// requester holds the identity of the agent requesting the template
        /// instantiation.
        /// </summary>
        [JsonProperty(PropertyName = "requester")]
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1TemplateInstanceRequester Requester { get; set; }

        /// <summary>
        /// secret is a reference to a Secret object containing the necessary
        /// template parameters.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Iok8skubernetespkgapiv1LocalObjectReference Secret { get; set; }

        /// <summary>
        /// template is a full copy of the template for instantiation.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1Template Template { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Requester == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Requester");
            }
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (this.Template != null)
            {
                this.Template.Validate();
            }
        }
    }
}