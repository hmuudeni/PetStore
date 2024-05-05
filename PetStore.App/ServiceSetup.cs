using Microsoft.Extensions.DependencyInjection;
using PetStore.App.Services;
using PetStore.App.Utility;

namespace PetStore.App
{
	public class ServiceSetup
	{
		public IServiceProvider BuildServiceProvider()
		{
			// Create a new service collection
			var serviceCollection = new ServiceCollection();

			serviceCollection.Configure<ApiAccessor>(options =>
			{
				options.BaseUrl = AppSetting.GetBaseUrl();
			});

			// Register services
			serviceCollection.AddHttpClient<IPetService, PetService>();

			// build and return the service provider 

			return serviceCollection.BuildServiceProvider();
		}
	}
}
