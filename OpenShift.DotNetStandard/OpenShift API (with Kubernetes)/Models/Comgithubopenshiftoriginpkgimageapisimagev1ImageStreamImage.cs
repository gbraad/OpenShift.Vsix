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
    /// ImageStreamImage represents an Image that is retrieved by image name
    /// from an ImageStream.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamImage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamImage class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamImage() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamImage class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamImage(Comgithubopenshiftoriginpkgimageapisimagev1Image image, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Image = image;
            Kind = kind;
            Metadata = metadata;
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
        /// Image associated with the ImageStream and image name.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Comgithubopenshiftoriginpkgimageapisimagev1Image Image { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
            if (this.Image != null)
            {
                this.Image.Validate();
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}