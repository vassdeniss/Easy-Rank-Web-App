﻿// -----------------------------------------------------------------------
// <copyright file="AccountServiceMock.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Linq;

using EasyRank.Infrastructure.Models.Accounts;
using EasyRank.Services.Contracts;

using Microsoft.AspNetCore.Identity;

using Moq;

namespace EasyRank.Web.UnitTests.Mocks
{
    public class AccountServiceMock
    {
        public static Mock<IAccountService> MockAccountService(params EasyRankUser[] userList)
        {
            Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
            accountServiceMock.Setup(@as => @as.CreateUserAsync(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()))!
                .ReturnsAsync((string email, string firstName, string lastName, string userName, string password) => password == "ReturnInvalidResult"
                    ? IdentityResult.Failed(new IdentityError { Description = "Error", })
                    : IdentityResult.Success);

            accountServiceMock.Setup(@as => @as.IsEmailConfirmedAsync(
                    It.IsAny<string>()))!
                .ReturnsAsync((string email) => 
                    userList.FirstOrDefault(u => u.Email == email)!.EmailConfirmed);

            accountServiceMock.Setup(@as => @as.SignInUserAsync(
                    It.IsAny<string>(),
                    It.IsAny<string>()))!
                .ReturnsAsync((string email, string password)
                    => password == "ReturnInvalidResult"
                        ? SignInResult.Failed
                        : SignInResult.Success);

            accountServiceMock.Setup(@as => @as.GenerateEmailConfirmationTokenAsync(
                    It.IsAny<Guid>()))!
                .ReturnsAsync("random-token");

            accountServiceMock.Setup(@as => @as.GeneratePasswordResetTokenAsync(
                    It.IsAny<Guid>()))!
                .ReturnsAsync("random-token");

            accountServiceMock.Setup(@as => @as.DoesUserExist(
                    It.IsAny<string>()))!
                .ReturnsAsync((string email)
                    => userList.FirstOrDefault(u => u.Email == email) != null);

            accountServiceMock.Setup(@as => @as.ResetPasswordAsync(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()))!
                .ReturnsAsync((string email, string code, string pass) => code == "FailCheck"
                    ? IdentityResult.Failed(new IdentityError
                    {
                        Code = "123",
                        Description = "error",
                    })
                    : IdentityResult.Success);

            return accountServiceMock;
        }
    }
}
