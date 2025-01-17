// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list active security admin rules. It contains a list of active security admin rules and a skiptoken to get the next set of results. </summary>
    internal partial class ActiveSecurityAdminRulesListResult
    {
        /// <summary> Initializes a new instance of ActiveSecurityAdminRulesListResult. </summary>
        internal ActiveSecurityAdminRulesListResult()
        {
            Value = new ChangeTrackingList<ActiveBaseSecurityAdminRule>();
        }

        /// <summary> Initializes a new instance of ActiveSecurityAdminRulesListResult. </summary>
        /// <param name="value">
        /// Gets a page of active security admin rules.
        /// Please note <see cref="ActiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveSecurityAdminRule"/> and <see cref="ActiveDefaultSecurityAdminRule"/>.
        /// </param>
        /// <param name="skipToken"> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </param>
        internal ActiveSecurityAdminRulesListResult(IReadOnlyList<ActiveBaseSecurityAdminRule> value, string skipToken)
        {
            Value = value;
            SkipToken = skipToken;
        }

        /// <summary>
        /// Gets a page of active security admin rules.
        /// Please note <see cref="ActiveBaseSecurityAdminRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveSecurityAdminRule"/> and <see cref="ActiveDefaultSecurityAdminRule"/>.
        /// </summary>
        public IReadOnlyList<ActiveBaseSecurityAdminRule> Value { get; }
        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; }
    }
}
