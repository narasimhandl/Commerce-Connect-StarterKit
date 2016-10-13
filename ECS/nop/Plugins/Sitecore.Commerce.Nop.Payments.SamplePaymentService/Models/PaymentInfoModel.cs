﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaymentInfoModel.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>
//   Defines the PaymentInfoModel class.
// </summary>
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
// -----------------------------------------------------------------

namespace Sitecore.Commerce.Nop.Payments.SamplePaymentService.Models
{
    using global::Nop.Web.Framework.Mvc;
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the payment info model for the sample payment service payment method.
    /// </summary>
    public class PaymentInfoModel : BaseNopModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string DescriptionText { get; set; }
    }
}