﻿using System.Threading.Tasks;

using EasyRank.Services.Exceptions;

using Microsoft.AspNetCore.Identity;

namespace EasyRank.Services.Contracts
{
    // TODO: order namespaces
    // TODO: document

    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(
            string email,
            string? firstName,
            string? lastName,
            string userName,
            string password);

        Task<bool> IsEmailConfirmedAsync(string email);

        /// <summary>
        /// Used for signing the current user to the app.
        /// </summary>
        /// <param name="email">The email of the current user.</param>
        /// <param name="password">The password of the current user.</param>
        /// <returns>A 'SignInResult' to be verified by the controller.</returns>
        /// <exception cref="NotFoundException">NotFoundException is thrown when the user is not found.</exception>
        Task<SignInResult> SignInUserAsync(string email, string password);
    }
}
