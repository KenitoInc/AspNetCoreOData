﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.OData.Tests.Models
{
    public class OrderLine
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int OrderId { get; set; }
    }
}