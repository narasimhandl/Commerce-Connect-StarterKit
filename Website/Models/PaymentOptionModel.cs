﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaymentOptionModel.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>Defines the PaymentOptionModel class.</summary>
// --------------------------------------------------------------------------------------------------------------------
// Copyright 2016 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// ---------------------------------------------------------------------
namespace Sitecore.Commerce.StarterKit.Models
{
    /// <summary>
    /// Represents payment option information.
    /// </summary>
    public class PaymentOptionModel
    {
        /// <summary>
        /// Gets or sets the payment option name.
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// Gets or sets the payment option type.
        /// </summary>
        public int OptionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the payment option is selected.
        /// </summary>
        public bool Selected { get; set; }
    }
}