using PetStore.App.Services.Providers;

public class Program
{
	public static async Task Main(string[] args)
	{
		var serviceProvider = new PetServiceProvider();

		var PetService = serviceProvider.GetPetService();
	}
}
