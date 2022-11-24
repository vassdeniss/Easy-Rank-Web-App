﻿using AutoMapper;

using EasyRank.Infrastructure.Common;
using EasyRank.Infrastructure.Data;
using EasyRank.Services.UnitTests.Mocks;
using EasyRank.Tests.Common;

using NUnit.Framework;

namespace EasyRank.Services.UnitTests
{
    public class UnitTestBase
    {
        protected EasyRankTestDb testDb;
        protected EasyRankDbContext dbContext;
        protected IMapper mapper;
        protected IRepository repo;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContext = DatabaseMock.Instance;
            this.testDb = new EasyRankTestDb(this.dbContext);
            this.mapper = MapperMock.Instance;
            this.repo = new RepoMock(this.dbContext);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Dispose();
        }
    }
}