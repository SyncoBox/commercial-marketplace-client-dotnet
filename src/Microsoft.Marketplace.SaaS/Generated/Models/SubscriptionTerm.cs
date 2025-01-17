// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Marketplace.SaaS.Models
{
    /// <summary> The SubscriptionTerm. </summary>
    public partial class SubscriptionTerm
    {
        /// <summary> Initializes a new instance of SubscriptionTerm. </summary>
        internal SubscriptionTerm()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionTerm. </summary>
        /// <param name="startDate"> . </param>
        /// <param name="endDate"> . </param>
        internal SubscriptionTerm(DateTimeOffset? startDate, DateTimeOffset? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        public TermUnitEnum TermUnit { get; }
        public DateTimeOffset? StartDate { get; }
        public DateTimeOffset? EndDate { get; }
    }
}
