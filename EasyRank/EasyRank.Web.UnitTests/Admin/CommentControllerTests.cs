﻿// -----------------------------------------------------------------------
// <copyright file="CommentControllerTests.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using EasyRank.Services.Contracts.Admin;
using EasyRank.Web.Areas.Admin.Controllers;
using EasyRank.Web.Areas.Admin.Models.Comment;

using Microsoft.AspNetCore.Mvc;

using Moq;

using NUnit.Framework;

namespace EasyRank.Web.UnitTests.Admin
{
    [TestFixture]
    public class CommentControllerTests : UnitTestBase
    {
        private CommentController commentController;

        [SetUp]
        public void SetUp()
        {
            this.commentController = new CommentController(this.mapper, new Mock<IAdminService>().Object);
        }

        [Test]
        public async Task Test_All_ReturnsCorrectView()
        {
            // Arrange:

            // Act: invoke the controller method
            IActionResult result = await this.commentController.AllAsync();

            // Assert: returned result is not null, it is a view
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<ViewResult>());

            // Assert: view model is a collection of type 'CommentViewModelExtended'
            ViewResult viewResult = (result as ViewResult)!;
            Assert.That(viewResult.ViewData.Model, Is.InstanceOf<IEnumerable<CommentViewModelExtended>>());
        }
    }
}
