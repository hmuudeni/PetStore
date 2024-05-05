using PetStore.App.Models;

namespace PetStore.App.Services
{
	public interface IPetService
	{
		Task<List<Pet>> GetAvailablePetsAsync(string findByStatus);
	}
}
