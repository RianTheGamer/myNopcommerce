﻿using Nop.Core.Configuration;
using Nop.Plugin.Tax.Avalara.Domain;

namespace Nop.Plugin.Tax.Avalara
{
    /// <summary>
    /// Represents plugin settings
    /// </summary>
    public class AvalaraTaxSettings : ISettings
    {
        /// <summary>
        /// Gets or sets Avalara account ID
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets Avalara account license key
        /// </summary>
        public string LicenseKey { get; set; }

        /// <summary>
        /// Gets or sets company code
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use sandbox (testing environment)
        /// </summary>
        public bool UseSandbox { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to commit tax transactions right after they are saved
        /// </summary>
        public bool CommitTransactions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to validate entered by customer addresses before the tax calculation
        /// </summary>
        public bool ValidateAddress { get; set; }

        /// <summary>
        /// Gets or sets a type of the tax origin address
        /// </summary>
        public TaxOriginAddressType TaxOriginAddressType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable logging of all requests
        /// </summary>
        public bool EnableLogging { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to get the tax rate by address only. 
        /// </summary>
        public bool GetTaxRateByAddressOnly { get; set; }

        /// <summary>
        /// Gets or sets the tax rate (by address) cache time in minutes
        /// </summary>
        public int TaxRateByAddressCacheTime { get; set; }
    }
}