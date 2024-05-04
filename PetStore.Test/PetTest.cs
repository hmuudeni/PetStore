using Microsoft.Extensions.Options;
using Moq;
using PetStore.App.Services;
using PetStore.App.Utility;

namespace PetStore.Test
{
	[TestClass]
	public class PetTest
	{
		[TestMethod]
		public async Task ShouldFindPetsByStatus()
		{
			var httpClientMock = new Mock<HttpClient>();

			var apiAccessorMock = new Mock<IOptions<ApiAccessor>>();

			apiAccessorMock.Setup(x => x.Value).Returns(new ApiAccessor { BaseUrl = AppSetting.GetBaseUrl() });

			var petService = new PetService(httpClientMock.Object, apiAccessorMock.Object);

			// Act
			var actualPets = await petService.GetAvailablePetsAsync(PetStatusEnum.available.ToString());

			// Assert
			Assert.IsNotNull(actualPets);
			Assert.IsTrue(actualPets.Count > 0);
		}
	}
}