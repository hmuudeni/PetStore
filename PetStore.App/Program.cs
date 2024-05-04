using PetStore.App.Helper;
using PetStore.App.Services.Providers;
using PetStore.App.Utility;

public class Program
{
	public static async Task Main(string[] args)
	{
		try
		{
			var serviceProvider = new PetServiceProvider();

			var PetService = serviceProvider.GetPetService();

			var listOfPets = await PetService.GetAvailablePetsAsync(PetStatusEnum.available.ToString());

			if (listOfPets.Count != 0)
			{
				PetHelper.PrintGroupAndSortPets(listOfPets);
			}
			else
			{
				Console.WriteLine("No available pets.");
			}
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		
	}
}
