﻿// -----------------------------------------------------------------------
// <copyright file="IEntryService.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using EasyRank.Services.Exceptions;
using EasyRank.Services.Models.Entry;

namespace EasyRank.Services.Contracts
{
    /// <summary>
    /// The interface for the EntryService.
    /// </summary>
    public interface IEntryService
    {
        /// <summary>
        /// Checks if the current user owns the page.
        /// </summary>
        /// <returns>Task(void).</returns>
        /// <param name="userId">GUID used for retrieving the needed user.</param>
        /// <param name="rankId">GUID used for retrieving the needed page.</param>
        /// <param name="isAdmin">Flag indicating if the user is an admin.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the page was not found.</exception>
        /// <exception cref="ForbiddenException">Throws 'ForbiddenException' if the user
        /// is not the owner of the page.</exception>
        Task IsCurrentUserPageOwnerAsync(
            Guid userId,
            Guid rankId,
            bool isAdmin);

        /// <summary>
        /// Retrieves the form the user inputted, creates a page entry and saves it to the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="placement">The placement of the entry on the page.</param>
        /// <param name="title">The title of the entry.</param>
        /// <param name="image">The byte array containing the cover image.</param>
        /// <param name="imageAlt">The text to display when the image doesn't exist / load.</param>
        /// <param name="description">The entry description.</param>
        /// <param name="rankId">GUID used to search for the needed page.</param>
        Task CreateEntryAsync(
            int placement,
            string title,
            byte[]? image,
            string imageAlt,
            string description,
            Guid rankId);

        /// <summary>
        /// Retrieves the numbers (1-10) that can be used for a new entry placement on the current rank page.
        /// </summary>
        /// <param name="rankId">GUID used to search for the needed page.</param>
        /// <returns>Collection of numbers representing available space.</returns>
        Task<ICollection<int>> GetAvailablePlacementsAsync(Guid rankId);

        /// <summary>
        /// Edits the entry and saves it back to the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="entryId">GUID used for retrieving the needed entry.</param>
        /// <param name="placement">The placement of the entry in the rank page.</param>
        /// <param name="entryTitle">The entry title.</param>
        /// <param name="image">The byte array containing the cover image.</param>
        /// <param name="imageAlt">The text to display when the image doesn't exist / load.</param>
        /// <param name="entryDescription">The description of the entry.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the entry was not found.</exception>
        Task EditEntryAsync(
            Guid entryId,
            int placement,
            string entryTitle,
            byte[]? image,
            string imageAlt,
            string entryDescription);

        /// <summary>
        /// Used for retrieving a rank entry from the database by its GUID.
        /// </summary>
        /// <returns>A rank entry service model.</returns>
        /// <param name="entryGuid">GUID used to search for the rank entry.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the rank entry was not found.</exception>
        Task<RankEntryServiceModel> GetRankEntryByGuidAsync(Guid entryGuid);

        /// <summary>
        /// Deletes an entry from the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="entryId">GUID used for retrieving the needed rank entry.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the entry was not found.</exception>
        /// <remarks>Sets a 'IsDeleted' flag. Doesn't actually delete.</remarks>
        Task DeleteEntryAsync(Guid entryId);
    }
}
