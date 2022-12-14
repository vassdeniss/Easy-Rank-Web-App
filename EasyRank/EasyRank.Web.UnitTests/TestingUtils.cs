﻿// -----------------------------------------------------------------------
// <copyright file="TestingUtils.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Text;

using AngleSharp.Io;

using EasyRank.Infrastructure.Models.Accounts;
using EasyRank.Web.Extensions;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;

using Moq;

using SendGrid;

namespace EasyRank.Web.UnitTests
{
    public static class TestingUtils
    {
        public static T AddFormWithFile<T>(this T controller, string fileName)
            where T : Controller
        {
            controller.EnsureHttpContext();

            byte[] bytes = Encoding.UTF8.GetBytes("Dummy File");
            IFormFile file = new FormFile(
                new MemoryStream(bytes),
                0,
                bytes.Length,
                "Data",
                fileName);

            Dictionary<string, StringValues> emptyFieldsDictionary = new Dictionary<string, StringValues>();
            FormFileCollection formFiles = new FormFileCollection
            {
                file,
            };

            IFormCollection form = new FormCollection(emptyFieldsDictionary, formFiles);

            controller.HttpContext.Request.Form = form;

            return controller;
        }

        public static T AddRequestScheme<T>(this T controller)
            where T : Controller
        {
            controller.EnsureHttpContext();

            controller.HttpContext.Request.Scheme = "https";

            return controller;
        }

        public static T AddUrlHelper<T>(this T controller)
            where T : Controller
        {
            controller.EnsureHttpContext();

            Mock<IUrlHelper> urlHelperMock = new Mock<IUrlHelper>();
            urlHelperMock.Setup(helper => helper.Action(
                    It.IsAny<UrlActionContext>()))
                .Returns("callbackUrl");

            controller.Url = urlHelperMock.Object;

            return controller;
        }

        public static T AddTempData<T>(this T controller)
            where T : Controller
        {
            controller.EnsureHttpContext();

            ITempDataProvider tempDataProvider = Mock.Of<ITempDataProvider>();
            TempDataDictionaryFactory tempDataDictionaryFactory = new TempDataDictionaryFactory(tempDataProvider);
            ITempDataDictionary tempData = tempDataDictionaryFactory.GetTempData(new DefaultHttpContext());

            controller.TempData = tempData;

            return controller;
        }

        public static T AndMakeAdmin<T>(this T controller) 
            where T : Controller
        {
            string nameId = controller.ControllerContext.HttpContext.User.Id().ToString();
            string name = controller.ControllerContext.HttpContext.User.Identity!.Name!;
            ClaimsPrincipal principal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, nameId),
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, "Administrator"),
            }, "TestAuthentication"));

            controller.ControllerContext.HttpContext.User = principal;

            return controller;
        }

        public static T ButThenAuthenticateUsing<T>(this T controller, Guid nameIdentifier, string username) 
            where T : Controller
        {
            ClaimsPrincipal principal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, nameIdentifier.ToString()),
                new Claim(ClaimTypes.Name, username)
            }, "TestAuthentication"));

            controller.ControllerContext.HttpContext.User = principal;

            return controller;
        }

        public static T WithAnonymousUser<T>(this T controller) 
            where T : Controller
        {
            controller.EnsureHttpContext();

            ClaimsPrincipal principal = new ClaimsPrincipal(new ClaimsIdentity());

            controller.ControllerContext.HttpContext.User = principal;

            return controller;
        }

        public static ControllerContext CreateControllerContext(
            EasyRankUser user,
            string fileName = "",
            bool shouldBeAdmin = false)
        {

            // Create test file
            IFormCollection? form = null;

            // Create HTTP context
            return new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    Request =
                    {
                        Form = form,
                    }
                }
            };
        }

        private static T EnsureHttpContext<T>(this T controller) 
            where T : Controller
        {
            if (controller.ControllerContext == null)
            {
                controller.ControllerContext = new ControllerContext();
            }

            if (controller.ControllerContext.HttpContext == null)
            {
                controller.ControllerContext.HttpContext = new DefaultHttpContext();
            }

            return controller;
        }
    }
}
