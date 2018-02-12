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
    /// ScopeRestriction describe one restriction on scopes.  Exactly one
    /// option must be non-nil.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgoauthapisoauthv1ScopeRestriction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgoauthapisoauthv1ScopeRestriction class.
        /// </summary>
        public Comgithubopenshiftoriginpkgoauthapisoauthv1ScopeRestriction() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgoauthapisoauthv1ScopeRestriction class.
        /// </summary>
        public Comgithubopenshiftoriginpkgoauthapisoauthv1ScopeRestriction(Comgithubopenshiftoriginpkgoauthapisoauthv1ClusterRoleScopeRestriction clusterRole = default(Comgithubopenshiftoriginpkgoauthapisoauthv1ClusterRoleScopeRestriction), IList<string> literals = default(IList<string>))
        {
            ClusterRole = clusterRole;
            Literals = literals;
        }

        /// <summary>
        /// ClusterRole describes a set of restrictions for cluster role
        /// scoping.
        /// </summary>
        [JsonProperty(PropertyName = "clusterRole")]
        public Comgithubopenshiftoriginpkgoauthapisoauthv1ClusterRoleScopeRestriction ClusterRole { get; set; }

        /// <summary>
        /// ExactValues means the scope has to match a particular set of
        /// strings exactly
        /// </summary>
        [JsonProperty(PropertyName = "literals")]
        public IList<string> Literals { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ClusterRole != null)
            {
                this.ClusterRole.Validate();
            }
        }
    }
}