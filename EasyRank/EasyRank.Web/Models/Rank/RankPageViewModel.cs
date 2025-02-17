﻿// -----------------------------------------------------------------------
// <copyright file="RankPageViewModel.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

namespace EasyRank.Web.Models.Rank
{
    /// <summary>
    /// The UI side model for the rank page.
    /// </summary>
    public class RankPageViewModel
    {
        /// <summary>
        /// Gets or sets the unique GUID identifier for a ranking page.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the image for a rank page.
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// Gets or sets the alternative text if the image is broken.
        /// </summary>
        public string ImageAlt { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the ranking page.
        /// </summary>
        public string RankingTitle { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date & time a ranking page has been created on.
        /// </summary>
        public string CreatedOn { get; set; } = null!;

        /// <summary>
        /// Gets or sets the like count of the ranking page.
        /// </summary>
        [Display(Name = "Likes")]
        public int LikeCount { get; set; }

        /// <summary>
        /// Gets or sets the username for the author of the ranking page.
        /// </summary>
        public string CreatedByUserName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the comment count for the ranking page.
        /// </summary>
        [Display(Name = "Comments")]
        public int CommentCount { get; set; }
    }
}
