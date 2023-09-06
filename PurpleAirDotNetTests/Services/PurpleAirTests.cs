using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using PurpleAirDotNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PurpleAirDotNet.Services.Tests;

[TestClass()]
public class PurpleAirTests
{
	[TestMethod()]
	public async Task GetSensorAsyncTest()
	{
		// Arrange
		var handlerMock = new Mock<HttpMessageHandler>();
		var response = new HttpResponseMessage
		{
			StatusCode = HttpStatusCode.OK,
			Content = new StringContent("{ 'property1': 'value1', 'property2': 'value2' }"), // Mock response content with your API response structure
		};

		handlerMock
		   .Protected()
		   .Setup<Task<HttpResponseMessage>>(
			  "SendAsync",
			  ItExpr.IsAny<HttpRequestMessage>(),
			  ItExpr.IsAny<CancellationToken>()
		   )
		   .ReturnsAsync(response)
		   .Verifiable();

		var httpClient = new HttpClient(handlerMock.Object);
		var accessToken = "your_access_token_here";
		var server = "your_server_url_here";

		var purpleAir = new PurpleAir(accessToken, server);

		// Act
		var result = await purpleAir.GetSensorAsync(132705); 

		// Assert
		Assert.IsNotNull(result);
		handlerMock.Protected().Verify(
		   "SendAsync",
		   Times.Exactly(1),
		   ItExpr.IsAny<HttpRequestMessage>(),
		   ItExpr.IsAny<CancellationToken>()
		);
	}
}
