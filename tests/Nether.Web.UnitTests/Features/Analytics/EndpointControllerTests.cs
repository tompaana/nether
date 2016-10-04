﻿using Microsoft.AspNetCore.Mvc;
using Nether.Web.Features.Analytics;
using Xunit;

namespace Nether.Web.UnitTests.Features.Analytics
{
    public class EndpointControllerTests
    {
        [Fact]
        public void ShouldBeAbleToRetrieveEndpointInformation()
        {
            // Arrange
            //TODO: Configure endpoint controller, as soon as we can handle configurations
            var controller = new EndpointController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = okResult.Value as AnalyticsEndpointInfoResponseModel;
            Assert.NotNull(model);

            //TODO: Add additional asserts as soon as we can handle configurations witin unit tests

            Assert.Equal("POST", model.HttpVerb);
            Assert.NotEmpty(model.Url);
            Assert.Equal("application/json", model.ContentType);
            Assert.NotEmpty(model.Authorization);
        }
    }
}