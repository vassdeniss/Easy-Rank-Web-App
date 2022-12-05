﻿// -----------------------------------------------------------------------
// <copyright file="RankEntryServiceModelExtended.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace EasyRank.Services.Models
{
    /// <summary>
    /// Extended model of the rank entry holding more needed properties.
    /// </summary>
    public class RankEntryServiceModelExtended : RankEntryServiceModel
    {
        /// <summary>
        /// Gets or sets the ID of the rank page.
        /// </summary>
        public Guid RankPageId { get; set; }

        /// <summary>
        /// Gets or sets the username of the creator of the entry.
        /// </summary>
        public string Username { get; set; } = null!;
    }
}
