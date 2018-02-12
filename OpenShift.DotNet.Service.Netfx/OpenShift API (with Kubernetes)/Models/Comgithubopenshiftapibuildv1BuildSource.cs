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
    /// BuildSource is the SCM used for the build.
    /// </summary>
    public partial class Comgithubopenshiftapibuildv1BuildSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildSource class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapibuildv1BuildSource class.
        /// </summary>
        public Comgithubopenshiftapibuildv1BuildSource(string type, Comgithubopenshiftapibuildv1BinaryBuildSource binary = default(Comgithubopenshiftapibuildv1BinaryBuildSource), string contextDir = default(string), string dockerfile = default(string), Comgithubopenshiftapibuildv1GitBuildSource git = default(Comgithubopenshiftapibuildv1GitBuildSource), IList<Comgithubopenshiftapibuildv1ImageSource> images = default(IList<Comgithubopenshiftapibuildv1ImageSource>), IList<Comgithubopenshiftapibuildv1SecretBuildSource> secrets = default(IList<Comgithubopenshiftapibuildv1SecretBuildSource>), Iok8sapicorev1LocalObjectReference sourceSecret = default(Iok8sapicorev1LocalObjectReference))
        {
            Binary = binary;
            ContextDir = contextDir;
            Dockerfile = dockerfile;
            Git = git;
            Images = images;
            Secrets = secrets;
            SourceSecret = sourceSecret;
            Type = type;
        }

        /// <summary>
        /// binary builds accept a binary as their input. The binary is
        /// generally assumed to be a tar, gzipped tar, or zip file depending
        /// on the strategy. For Docker builds, this is the build context and
        /// an optional Dockerfile may be specified to override any
        /// Dockerfile in the build context. For Source builds, this is
        /// assumed to be an archive as described above. For Source and
        /// Docker builds, if binary.asFile is set the build will receive a
        /// directory with a single file. contextDir may be used when an
        /// archive is provided. Custom builds will receive this binary as
        /// input on STDIN.
        /// </summary>
        [JsonProperty(PropertyName = "binary")]
        public Comgithubopenshiftapibuildv1BinaryBuildSource Binary { get; set; }

        /// <summary>
        /// contextDir specifies the sub-directory where the source code for
        /// the application exists. This allows to have buildable sources in
        /// directory other than root of repository.
        /// </summary>
        [JsonProperty(PropertyName = "contextDir")]
        public string ContextDir { get; set; }

        /// <summary>
        /// dockerfile is the raw contents of a Dockerfile which should be
        /// built. When this option is specified, the FROM may be modified
        /// based on your strategy base image and additional ENV stanzas from
        /// your strategy environment will be added after the FROM, but
        /// before the rest of your Dockerfile stanzas. The Dockerfile source
        /// type may be used with other options like git - in those cases the
        /// Git repo will have any innate Dockerfile replaced in the context
        /// dir.
        /// </summary>
        [JsonProperty(PropertyName = "dockerfile")]
        public string Dockerfile { get; set; }

        /// <summary>
        /// git contains optional information about git build source
        /// </summary>
        [JsonProperty(PropertyName = "git")]
        public Comgithubopenshiftapibuildv1GitBuildSource Git { get; set; }

        /// <summary>
        /// images describes a set of images to be used to provide source for
        /// the build
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<Comgithubopenshiftapibuildv1ImageSource> Images { get; set; }

        /// <summary>
        /// secrets represents a list of secrets and their destinations that
        /// will be used only for the build.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<Comgithubopenshiftapibuildv1SecretBuildSource> Secrets { get; set; }

        /// <summary>
        /// sourceSecret is the name of a Secret that would be used for
        /// setting up the authentication for cloning private repository. The
        /// secret contains valid credentials for remote repository, where
        /// the data's key represent the authentication method to be used and
        /// value is the base64 encoded credentials. Supported auth methods
        /// are: ssh-privatekey.
        /// </summary>
        [JsonProperty(PropertyName = "sourceSecret")]
        public Iok8sapicorev1LocalObjectReference SourceSecret { get; set; }

        /// <summary>
        /// type of build input to accept
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (this.Git != null)
            {
                this.Git.Validate();
            }
            if (this.Images != null)
            {
                foreach (var element in this.Images)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Secrets != null)
            {
                foreach (var element1 in this.Secrets)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}