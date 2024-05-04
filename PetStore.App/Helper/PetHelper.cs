using PetStore.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.App.Helper
{
	public static class PetHelper
	{
		public static void PrintGroupAndSortPets(List<Pet> pets)
		{
			// Order pets by category name 

			var sortedPets = pets
			.Where(p => p.Category != null && p.Category?.Name != null)
			.Select(p =>  new
			{
				p.Name,
				CatergoryName = p.Category.Name
			})
			.OrderBy(p => p.CatergoryName, StringComparer.OrdinalIgnoreCase)
			.ThenByDescending(p => p.Name);

			var sortedResults = sortedPets.ToList();

			// Output to console
			Console.WriteLine("Available pets sorted by category and displayed in reverse order by name:");
			Console.WriteLine("---------------------------------------------------------------------------");

			foreach (var pet in sortedResults)
			{
				Console.WriteLine($"Name: {pet.Name}, Category: {pet.CatergoryName}");
			}

		}
	}
}
