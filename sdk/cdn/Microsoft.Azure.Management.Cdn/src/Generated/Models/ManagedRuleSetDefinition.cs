// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a managed rule set definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedRuleSetDefinition : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedRuleSetDefinition class.
        /// </summary>
        public ManagedRuleSetDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedRuleSetDefinition class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">Provisioning state of the managed
        /// rule set.</param>
        /// <param name="ruleSetType">Type of the managed rule set.</param>
        /// <param name="ruleSetVersion">Version of the managed rule set
        /// type.</param>
        /// <param name="ruleGroups">Rule groups of the managed rule
        /// set.</param>
        /// <param name="sku">The pricing tier (defines a CDN provider, feature
        /// list and rate) of the CdnWebApplicationFirewallPolicy.</param>
        public ManagedRuleSetDefinition(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), string ruleSetType = default(string), string ruleSetVersion = default(string), IList<ManagedRuleGroupDefinition> ruleGroups = default(IList<ManagedRuleGroupDefinition>), Sku sku = default(Sku))
            : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the managed rule set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets type of the managed rule set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleSetType")]
        public string RuleSetType { get; private set; }

        /// <summary>
        /// Gets version of the managed rule set type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleSetVersion")]
        public string RuleSetVersion { get; private set; }

        /// <summary>
        /// Gets rule groups of the managed rule set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleGroups")]
        public IList<ManagedRuleGroupDefinition> RuleGroups { get; private set; }

        /// <summary>
        /// Gets or sets the pricing tier (defines a CDN provider, feature list
        /// and rate) of the CdnWebApplicationFirewallPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

    }
}
