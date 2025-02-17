﻿// -----------------------------------------------------------------------
// <copyright file="ViewModelMappingProfile.cs" company="Denis Vasilev">
// Copyright (c) Denis Vasilev. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using AutoMapper;

using EasyRank.Services.Models.Admin;
using EasyRank.Services.Models.Comment;
using EasyRank.Services.Models.Email;
using EasyRank.Services.Models.Entry;
using EasyRank.Services.Models.Rank;
using EasyRank.Services.Models.User;
using EasyRank.Web.Areas.Admin.Models.Comment;
using EasyRank.Web.Areas.Admin.Models.Entry;
using EasyRank.Web.Areas.Admin.Models.User;
using EasyRank.Web.Models.Manage;
using EasyRank.Web.Models.Rank;

namespace EasyRank.Web.Profiles
{
    /// <summary>
    /// Class used for configuring service-to-view model AutoMapper profiles.
    /// </summary>
    public class ViewModelMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelMappingProfile"/> class.
        /// Constructor for the controller mapping profile class.
        /// </summary>
        public ViewModelMappingProfile()
        {
            this.AllowNullCollections = true;

            this.CreateMap<RankPageServiceModel, RankPageViewModel>();
            this.CreateMap<RankEntryServiceModel, RankEntryViewModel>();
            this.CreateMap<RankPageServiceModelExtended, RankPageViewModelExtended>();
            this.CreateMap<CommentServiceModel, CommentViewModel>();
            this.CreateMap<ManageServiceModel, ManageViewModel>();
            this.CreateMap<EmailServiceModel, EmailViewModel>();
            this.CreateMap<AllRanksServiceModel, AllRanksViewModel>();
            this.CreateMap<RankEntryServiceModelExtended, RankEntryViewModelExtended>();
            this.CreateMap<CommentServiceModelExtended, CommentViewModelExtended>();
            this.CreateMap<EasyRankUserServiceModel, EasyRankUserViewModel>();
        }
    }
}
