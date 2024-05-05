using Microsoft.Extensions.DependencyInjection;

namespace PetStore.App.Services.Providers
{
	public class PetServiceProvider
	{
		public IPetService GetPetService()
		{
			var serviceSetup = new ServiceSetup();

			var serviceProvider = serviceSetup.BuildServiceProvider();

			return serviceProvider.GetRequiredService<IPetService>();
		}
	}
}
