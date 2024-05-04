using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
