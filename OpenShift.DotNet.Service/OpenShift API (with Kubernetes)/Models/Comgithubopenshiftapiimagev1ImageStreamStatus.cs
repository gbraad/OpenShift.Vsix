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
    /// ImageStreamStatus contains information about the state of this image
    /// stream.
    /// </summary>
    public partial class Comgithubopenshiftapiimagev1ImageStreamStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamStatus class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamStatus class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamStatus(string dockerImageRepository, string publicDockerImageRepository = default(string), IList<Comgithubopenshiftapiimagev1NamedTagEventList> tags = default(IList<Comgithubopenshiftapiimagev1NamedTagEventList>))
        {
            DockerImageRepository = dockerImageRepository;
            PublicDockerImageRepository = publicDockerImageRepository;
            Tags = tags;
        }

        /// <summary>
        /// DockerImageRepository represents the effective location this
        /// stream may be accessed at. May be empty until the server
        /// determines where the repository is located
        /// </summary>
        [JsonProperty(PropertyName = "dockerImageRepository")]
        public string DockerImageRepository { get; set; }

        /// <summary>
        /// PublicDockerImageRepository represents the public location from
        /// where the image can be pulled outside the cluster. This field may
        /// be empty if the administrator has not exposed the integrated
        /// registry externally.
        /// </summary>
        [JsonProperty(PropertyName = "publicDockerImageRepository")]
        public string PublicDockerImageRepository { get; set; }

        /// <summary>
        /// Tags are a historical record of images associated with each tag.
        /// The first entry in the TagEvent array is the currently tagged
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<Comgithubopenshiftapiimagev1NamedTagEventList> Tags { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (DockerImageRepository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DockerImageRepository");
            }
            if (this.Tags != null)
            {
                foreach (var element in this.Tags)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
