﻿// -----------------------------------------------------------------------
// <copyright file="ICommentService.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

using EasyRank.Services.Exceptions;
using EasyRank.Services.Models.Comment;

namespace EasyRank.Services.Contracts
{
    /// <summary>
    /// The interface for the CommentService.
    /// </summary>
    public interface ICommentService
    {
        /// <summary>
        /// Retrieves the content the user inputted, creates a comment, and saves it to the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="content">The content of the comment.</param>
        /// <param name="createdByUserId">GUID used to identify the user which posted the comment.</param>
        /// <param name="rankPageId">GUID used for retrieving the rank page where the comment was posted.</param>
        Task CreateCommentAsync(
            string content,
            Guid createdByUserId,
            Guid rankPageId);

        /// <summary>
        /// Retrieves a specific comment by its id from the database.
        /// </summary>
        /// <returns>A comment service model.</returns>
        /// <param name="commentId">GUID used for retrieving the needed comment.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the comment was not found.</exception>
        Task<CommentServiceModel> GetCommentByIdAsync(Guid commentId);

        /// <summary>
        /// Edits the content of a comment and saves it back to the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="commentId">GUID used for retrieving the needed comment.</param>
        /// <param name="content">The (sanitized) content of the comment to be replaced.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the comment was not found.</exception>
        Task EditCommentAsync(
            Guid commentId,
            string content);

        /// <summary>
        /// Deletes a comment from the database.
        /// </summary>
        /// <returns>Task (void).</returns>
        /// <param name="commentId">GUID used for retrieving the needed comment.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the comment was not found.</exception>
        /// <remarks>Sets a 'IsDeleted' flag. Doesn't actually delete.</remarks>
        Task DeleteCommentAsync(Guid commentId);

        /// <summary>
        /// Checks if the current user owns the comment (or if the user is owner of page).
        /// </summary>
        /// <returns>Task(void).</returns>
        /// <param name="userId">GUID used for retrieving the needed user.</param>
        /// <param name="commentId">GUID used for retrieving the needed comment.</param>
        /// <param name="isAdmin">Flag indicating if the user is an admin.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the comment was not found.</exception>
        /// <exception cref="ForbiddenException">
        /// Throws 'ForbiddenException' if the user is not the owner of the comment.
        /// </exception>
        Task IsCurrentUserCommentOwnerAsync(
            Guid userId,
            Guid commentId,
            bool isAdmin);

        /// <summary>
        /// Gets the page id through the comment.
        /// </summary>
        /// <returns>The GUID of the page.</returns>
        /// <param name="commentId">GUID used for retrieving the needed comment.</param>
        /// <exception cref="NotFoundException">Throws 'NotFoundException' if the comment was not found.</exception>
        Task<Guid> GetCommentPageIdAsync(Guid commentId);
    }
}
